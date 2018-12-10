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
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Util;

namespace PalcoNet.EditarPublicacion
{
    public partial class EditarPublicacionSeleccionada : Form
    {
        private PublicacionRepository publicacionRepository;
        private UbicacionRepository ubicacionRepository;
        private RubroRepository rubroRepository;
        private GradoDePublicacionRepository gradoDePublicacionRepository;
        private EstadoDePublicacionRepository estadoDePublicacionRepository;

        private Publicacion publicacionSeleccionada;
        private EditarPublicacionForm callerForm;

        private IList<UbicacionPersistente> ubicacionesAEliminar;
        private IList<UbicacionPersistente> ubicacionesAInsertar;

        public EditarPublicacionSeleccionada(decimal idPublicacionSeleccionada, EditarPublicacionForm callerForm)
        {
            InitializeComponent();
            this.InitializeRepositories();
            this.publicacionSeleccionada = publicacionRepository.BuscarPorId(idPublicacionSeleccionada);
            this.InitializeForm();
            this.callerForm = callerForm;
            this.ubicacionesAEliminar = new List<UbicacionPersistente>();
            this.ubicacionesAInsertar = new List<UbicacionPersistente>();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.SetPublicacionNewValues();

            if (this.ValidateDates())
            {
                if (!publicacionRepository.ExisteUnaPublicacionIgual(publicacionSeleccionada))
                {
                    publicacionRepository.ActualizarPublicacion(publicacionSeleccionada);
                    MessageBoxUtil.ShowInfo("Publicacion actualizada correctamente.");
                    
                    callerForm.ActualizarDataGrid();
                    NavigableFormUtil.BackwardTo(this, callerForm);
                }
                else
                {
                    MessageBoxUtil.ShowError("Existe una publicacion igual.");
                }
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
        
        private void btnLimpiarUbicaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveUbicacion_Click(object sender, EventArgs e)
        {
            dgvUbicaciones.SelectedRows[0].Visible = false;
            this.AddUbicacionAEliminar();
        }

        private void btnAgregarUbicacion_Click(object sender, EventArgs e)
        {
            new AgregarUbicacionForm(this).ShowDialog();
        }
        
        #region Auxiliary methods
        private void InitializeForm() 
        {
            this.InitializeTextFields();           
            this.FillComboBoxes();
            this.InitializeDGVUbicaciones();
        }

        private void InitializeRepositories() 
        {
            this.publicacionRepository = new PublicacionRepository();
            this.ubicacionRepository = new UbicacionRepository();
            this.gradoDePublicacionRepository = new GradoDePublicacionRepository();
            this.estadoDePublicacionRepository = new EstadoDePublicacionRepository();
            this.rubroRepository = new RubroRepository();
        }

        private void InitializeTextFields()
        {
            rTxtDescripcion.Text = publicacionSeleccionada.Descripcion;
            dtpFechaDeEspectaculo.Text = publicacionSeleccionada.FechaHoraDeEspectaculo.ToString();
            dtpHoraEspectaculo.Text = publicacionSeleccionada.FechaHoraDeEspectaculo.ToString();
            dtpFechaPublicacion.Text = publicacionSeleccionada.FechaDePublicacion.ToString();
            dtpVencimiento.Text = publicacionSeleccionada.FechaDeVencimiento.ToString();
            txtDireccion.Text = publicacionSeleccionada.DireccionEspectaculo;
        }

        private void FillComboBoxes()
        {            
            ComboBoxFiller<Rubro, decimal>.Fill(cmbRubro)
                .ValueAs(rubro => rubro.Descripcion)
                .KeyAs(rubro => rubro.IdRubro)
                .With(rubroRepository.TodosLosRubros())
                .CheckByDBId(int.Parse(publicacionSeleccionada.IdRubro.ToString()));

            ComboBoxFiller<EstadoDePublicacion, decimal>.Fill(cmbEstado)
                .KeyAs(estado => estado.IdEstadoDePublicacion)
                .ValueAs(estado => estado.Descripcion)
                .With(estadoDePublicacionRepository.TodosLosEstadosDePublicacion())
                .CheckByDBId(int.Parse(publicacionSeleccionada.IdEstado.ToString()));

            ComboBoxFiller<GradoDePublicacion, decimal>.Fill(cmbGrado)
                .KeyAs(grado => grado.IdGradoDePublicacion)
                .ValueAs(grado => grado.Descripcion)
                .With(gradoDePublicacionRepository.TodosLosGradosDePublicacion())
                .CheckByDBId(int.Parse(publicacionSeleccionada.IdGradoDePublicacion.ToString()));
        }

        private void InitializeDGVUbicaciones() 
        {
            IList<UbicacionPersistente> ubicaciones = ubicacionRepository.UbicacionesEditables(publicacionSeleccionada.CodPublicacion);

            foreach (UbicacionPersistente item in ubicaciones)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvUbicaciones);
                row.Cells[0].Value = item.Fila;
                row.Cells[1].Value = item.CantidadDeLugares;
                row.Cells[2].Value = item.Precio;
                row.Cells[3].Value = item.DescripcionTipoUbicacion;
                row.Cells[4].Value = item.IdTipoUbicacion;
                row.Cells[5].Value = false;

                dgvUbicaciones.Rows.Add(row);
                
            }
        }

        private void SetPublicacionNewValues()
        {
            publicacionSeleccionada.Descripcion = rTxtDescripcion.Text;
            publicacionSeleccionada.FechaDePublicacion = DateTimeUtil.DateOnly(dtpFechaPublicacion.Value);
            publicacionSeleccionada.FechaDeVencimiento = DateTimeUtil.DateOnly(dtpVencimiento.Value);
            publicacionSeleccionada.FechaHoraDeEspectaculo = DateTimeUtil.ZeroSeconds(DateTimeUtil.Of(dtpFechaDeEspectaculo.Value.ToShortDateString(), dtpHoraEspectaculo.Text));
            publicacionSeleccionada.IdRubro = ((ComboBoxItem<decimal>)cmbRubro.SelectedItem).Value;
            publicacionSeleccionada.IdEstado = ((ComboBoxItem<decimal>)cmbEstado.SelectedItem).Value;
            publicacionSeleccionada.IdGradoDePublicacion = ((ComboBoxItem<decimal>)cmbGrado.SelectedItem).Value;
        }

        private bool ValidateDates()
        {
            if (!DateTimeUtil.Before(publicacionSeleccionada.FechaDePublicacion, publicacionSeleccionada.FechaHoraDeEspectaculo))
            {
                MessageBoxUtil.ShowError("La fecha y hora de espectaculo debe ser posterior a la fecha de publicacion.");
                return false;
            }

            if (!DateTimeUtil.Before(publicacionSeleccionada.FechaHoraDeEspectaculo, publicacionSeleccionada.FechaDeVencimiento))
            {
                MessageBoxUtil.ShowError("La fecha de vencimiento debe ser posterior a la fecha y hora de publicacion.");
                return false;
            }

            if (!DateTimeUtil.Before(publicacionSeleccionada.FechaDePublicacion, publicacionSeleccionada.FechaDeVencimiento))
            {
                MessageBoxUtil.ShowError("La fecha de vencimiento debe ser posterior a la fecha de publicacion.");
                return false;
            }
            return true;
        }

        private void AddUbicacionAEliminar() 
        {
            if (!(bool)dgvUbicaciones.SelectedRows[0].Cells[5].Value)
            {
                UbicacionPersistente ubicacionAEliminar = new UbicacionPersistente();
                ubicacionAEliminar.CodPublicacion = publicacionSeleccionada.CodPublicacion;
                ubicacionAEliminar.Precio = dgvUbicaciones.SelectedRows[0].Cells[2].Value.ToString();
                ubicacionAEliminar.CantidadDeLugares = (int)dgvUbicaciones.SelectedRows[0].Cells[1].Value;
                ubicacionAEliminar.IdTipoUbicacion = (decimal)dgvUbicaciones.SelectedRows[0].Cells[4].Value;

                if (dgvUbicaciones.SelectedRows[0].Cells[0].Value.ToString().Equals("Sin numerar"))
                {
                    ubicacionAEliminar.SinNumerar = true;
                }
                else 
                {
                    ubicacionAEliminar.Fila = dgvUbicaciones.SelectedRows[0].Cells[0].Value.ToString().Split(' ')[1];
                    ubicacionAEliminar.SinNumerar = false;
                }

                ubicacionesAEliminar.Add(ubicacionAEliminar);
            }

        }

        public void AddUbicacionAInsertar(UbicacionPersistente ubicacion) 
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvUbicaciones);

            if (ubicacion.SinNumerar)
            {
                row.Cells[0].Value = "Sin numerar";
            }
            else
            {
                row.Cells[0].Value = "Fila " + ubicacion.Fila;
            }
            row.Cells[1].Value = ubicacion.CantidadDeLugares;
            row.Cells[2].Value = ubicacion.Precio;
            row.Cells[3].Value = ubicacion.DescripcionTipoUbicacion;
            row.Cells[4].Value = ubicacion.IdTipoUbicacion;
            row.Cells[5].Value = true;

            dgvUbicaciones.Rows.Add(row);
        }

        private bool ExisteFila(string fila)
        {
            foreach (DataGridViewRow row in dgvUbicaciones.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(fila))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
