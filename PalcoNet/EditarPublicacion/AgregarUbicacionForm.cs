using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Util;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Repository;

namespace PalcoNet.EditarPublicacion
{
    public partial class AgregarUbicacionForm : Form
    {
        private EditarPublicacionSeleccionada callerForm;
        private TipoDeUbicacionRepository tipoUbicacionRepository;

        public AgregarUbicacionForm(EditarPublicacionSeleccionada callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.tipoUbicacionRepository = new TipoDeUbicacionRepository();

            ComboBoxFiller<TipoDeUbicacion, decimal>.Fill(cmbTipoUbicacion)
                .KeyAs(tipo => tipo.IdTipoUbicacion)
                .ValueAs(tipo => tipo.Descripcion)
                .With(tipoUbicacionRepository.TodosLosTiposDeUbicacion());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            callerForm.AddUbicacionAInsertar(this.CrearUbicacionPersistente());
            this.Dispose();
            this.Close();
        }

        private UbicacionPersistente CrearUbicacionPersistente()
        {
            UbicacionPersistente ubicacion = new UbicacionPersistente();
            ubicacion.Fila = txtFila.Text;
            ubicacion.Precio = txtPrecio.Text;
            ubicacion.CantidadDeLugares = int.Parse(txtAsientos.Text);
            ubicacion.DescripcionTipoUbicacion = cmbTipoUbicacion.Text;
            ubicacion.IdTipoUbicacion = ((ComboBoxItem<decimal>)cmbTipoUbicacion.SelectedItem).Value;
            ubicacion.SinNumerar = rdbSinNumerar.Checked;
            ubicacion.CodPublicacion = callerForm.PublicacionSeleccionada().CodPublicacion;
            return ubicacion;
        }

        private void rdbFilasAsientos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilasAsientos.Checked)
            {
                lblFila.Visible = true;
                txtFila.Visible = true;
            }
        }

        private void rdbSinNumerar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSinNumerar.Checked)
            {
                lblFila.Visible = false;
                txtFila.Visible = false;
            }
        }
    }
}
