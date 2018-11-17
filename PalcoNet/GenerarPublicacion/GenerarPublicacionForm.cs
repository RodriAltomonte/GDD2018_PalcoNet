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

        public GenerarPublicacionForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.InitializeRepositories();
            this.InitializeControls();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //TODO
            try
            {
                publicacionRepository.CrearPublicacion(this.BuildPublicacion());
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
        }

        //TODO
        private Publicacion BuildPublicacion()
        {
            return new Publicacion();
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
                new AgregarFechaHora(this, dtpFechaPublicacion.Value).ShowDialog();
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
        #endregion
    }
}
