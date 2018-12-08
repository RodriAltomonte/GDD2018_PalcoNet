using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Util;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.Session;

namespace PalcoNet.GenerarPublicacion
{
    public partial class GenerarPublicacionForm : Form
    {
        private Form previousForm;
        private RubroRepository rubroRepository;
        private GradoDePublicacionRepository gradoRepository;
        private EstadoDePublicacionRepository estadoRepository;
        private TipoDeUbicacionRepository tipoUbicacionRepository;
        private PublicacionRepository publicacionRepository;
        private UbicacionRepository ubicacionRepository;

        public GenerarPublicacionForm()
        {
            InitializeComponent();
            //this.previousForm = previousForm;
            this.InitializeRepositories();
            this.InitializeControls();
        }

        public GenerarPublicacionForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.InitializeRepositories();
            this.InitializeControls();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {            
            try
            {
                if (ValidarExistenciaDeUbicaciones() && ValidarExistenciaDeFechas() && ValidarFechaDeVencimiento())
                {
                    IList<Publicacion> publicaciones = this.CrearListaDePublicaciones();
                    foreach (Publicacion publicacion in publicaciones)
                    {
                        decimal codPublicacionNueva = publicacionRepository.CrearPublicacion(publicacion);
                        IList<UbicacionPersistente> ubicaciones = this.CrearListaDeUbicaciones(codPublicacionNueva);

                        ubicacionRepository.InsertarListaDeUbicaciones(ubicaciones);                                       
                    }
                    MessageBoxUtil.ShowInfo("Publicación creada correctamente.");                    
                }
                
            }
            catch (StoredProcedureException)
            {
                MessageBoxUtil.ShowError("Error al generar la publicacion.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        #region Auxiliary methods
        private IList<Publicacion> CrearListaDePublicaciones() 
        {
            IList<Publicacion> publicaciones = new List<Publicacion>();

            foreach (ListViewItem item in lvFechaHora.Items)
            {
                Publicacion nuevaPublicacion = new Publicacion();
                nuevaPublicacion.Descripcion = rTxtDescripcion.Text;
                nuevaPublicacion.FechaDePublicacion = DateTimeUtil.DateOnly(dtpFechaPublicacion.Value);
                nuevaPublicacion.IdRubro = ((ComboBoxItem<decimal>)cmbRubro.SelectedItem).Value;
                nuevaPublicacion.DireccionEspectaculo = txtDireccion.Text;
                nuevaPublicacion.IdGradoDePublicacion = ((ComboBoxItem<decimal>)cmbGrado.SelectedItem).Value;
                nuevaPublicacion.IdEstado = ((ComboBoxItem<decimal>)cmbEstado.SelectedItem).Value;
                nuevaPublicacion.FechaDeVencimiento = DateTimeUtil.DateOnly(dtpVencimiento.Value);
                nuevaPublicacion.UsuarioEmpresa = Session.Instance().LoggedUsername;
                nuevaPublicacion.FechaHoraDeEspectaculo = DateTimeUtil.Of(item.Text, item.SubItems[1].Text);

                publicaciones.Add(nuevaPublicacion);
                
            }
            return publicaciones;
        }

        private IList<UbicacionPersistente> CrearListaDeUbicaciones(decimal codPublicacionNueva)
        {
            IList<UbicacionPersistente> ubicaciones = new List<UbicacionPersistente>();
            foreach (ListViewItem item in lvUbicaciones.Items)
            {
                UbicacionPersistente nuevaUbicacion = new UbicacionPersistente();

                if (item.Text == "Sin numerar")
                {
                    nuevaUbicacion.Fila = item.Text;
                    nuevaUbicacion.SinNumerar = true;
                }
                else
                {
                    nuevaUbicacion.Fila = item.Text.Split(' ')[1];
                    nuevaUbicacion.SinNumerar = false;
                }

                nuevaUbicacion.CantidadDeLugares = Convert.ToInt32(item.SubItems[1].Text);
                nuevaUbicacion.IdTipoUbicacion = 1;
                nuevaUbicacion.Precio = item.SubItems[2].Text;
                nuevaUbicacion.CodPublicacion = codPublicacionNueva;

                ubicaciones.Add(nuevaUbicacion);
            }
            return ubicaciones;
        }

        private void InitializeControls() 
        {
            ComboBoxFiller<Rubro, decimal>.Fill(cmbRubro)
                .KeyAs(rubro => rubro.IdRubro)
                .ValueAs(rubro => rubro.Descripcion)
                .With(rubroRepository.TodosLosRubros());

            ComboBoxFiller<GradoDePublicacion, decimal>.Fill(cmbGrado)
                .KeyAs(grado => grado.IdGradoDePublicacion)
                .ValueAs(grado => grado.Descripcion + " - " + grado.Porcentaje.ToString() + "%")
                .With(gradoRepository.TodosLosGradosDePublicacion());

            ComboBoxFiller<EstadoDePublicacion, decimal>.Fill(cmbEstado)
                .KeyAs(estado => estado.IdEstadoDePublicacion)
                .ValueAs(estado => estado.Descripcion)
                .With(estadoRepository.TodosLosEstadosDePublicacion());
        }

        private void InitializeRepositories()
        {            
            this.rubroRepository = new RubroRepository();
            this.gradoRepository = new GradoDePublicacionRepository();
            this.estadoRepository = new EstadoDePublicacionRepository();
            this.tipoUbicacionRepository = new TipoDeUbicacionRepository();
            this.publicacionRepository = new PublicacionRepository();
            this.ubicacionRepository = new UbicacionRepository();
        }
        #endregion

        #region Ubicacion
        private void btnAgregarUbicacion_Click(object sender, EventArgs e)
        {
            new AgregarUbicacionForm(this).ShowDialog();
        }

        private void btnLimpiarUbicaciones_Click(object sender, EventArgs e)
        {
            lvUbicaciones.Items.Clear();
        }

        private void btnRemoveUbicacion_Click(object sender, EventArgs e)
        {
            if (lvUbicaciones.SelectedItems.Count > 0)
            {
                lvUbicaciones.SelectedItems[0].Remove();
            }
        }

        public void AgregarUbicacion(string fila, string asientos, string precio, string tipoDeUbicacion)
        {
            ListViewItem item = new ListViewItem(fila);
            item.SubItems.Add(asientos);
            item.SubItems.Add(precio);
            item.SubItems.Add(tipoDeUbicacion);
            lvUbicaciones.Items.Add(item);
        }
        #endregion

        #region FechaHora
        private void btnAgregarFechaHora_Click(object sender, EventArgs e)
        {
            if (lvFechaHora.Items.Count == 0)
            {
                new AgregarFechaHora(this, DateTimeUtil.DateOnly(dtpFechaPublicacion.Value)).ShowDialog();
                dtpFechaPublicacion.Enabled = false;
            }
            else
            {
                new AgregarFechaHora(this, DateTimeUtil.Of(
                    Convert.ToDateTime(lvFechaHora.Items[lvFechaHora.Items.Count - 1].SubItems[0].Text),
                    Convert.ToDateTime(lvFechaHora.Items[lvFechaHora.Items.Count - 1].SubItems[1].Text)
                    )).ShowDialog();
            }
        }
        
        private void btnRemoverFechaHora_Click(object sender, EventArgs e)
        {
            if (lvFechaHora.Items.Count > 0)
            {
                lvFechaHora.SelectedItems[0].Remove();
                if (lvFechaHora.Items.Count == 0)
                {
                    dtpFechaPublicacion.Enabled = true;
                }                
            }
        }

        private void btnLimpiarFechaHora_Click(object sender, EventArgs e)
        {
            lvFechaHora.Items.Clear();
            dtpFechaPublicacion.Enabled = true;
        }

        public void AgregarItemFechaYHora(DateTime fecha, DateTime hora)
        {
            ListViewItem item = new ListViewItem(fecha.Date.ToShortDateString());
            item.SubItems.Add(hora.TimeOfDay.ToString());
            lvFechaHora.Items.Add(item);
        }

        public void AgregarItemFechaYHora(DateTime date)
        {
            ListViewItem item = new ListViewItem(date.Date.ToShortDateString());
            item.SubItems.Add(date.ToString("HH:mm"));
            lvFechaHora.Items.Add(item);
        }

        #endregion

        #region Validations
        private bool ValidarExistenciaDeFechas()
        {
            if (lvFechaHora.Items.Count<1)
            {
                MessageBoxUtil.ShowError("Debe ingresar al menos una fecha de espectaculo.");
                return false;
            }
            return true;
        }

        private bool ValidarFechaDeVencimiento() 
        {
            if (!DateTimeUtil.Before(lvFechaHora.Items[lvFechaHora.Items.Count - 1].Text, DateTimeUtil.DateOnly(dtpVencimiento.Value).ToShortDateString()))
            {
                MessageBoxUtil.ShowError("La fecha de vencimiento debe ser posterior al ultimo espectaculo.");
                return false;
            }
            return true;
        }

        private bool ValidarExistenciaDeUbicaciones()
        {
            if (lvUbicaciones.Items.Count < 1)
            {
                MessageBoxUtil.ShowError("Debe ingresar al menos una ubicacion.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
