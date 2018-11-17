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
using PalcoNet.Classes.Model;

namespace PalcoNet.GenerarPublicacion
{
    public partial class AgregarUbicacionForm : Form
    {
        private GenerarPublicacionForm form;
        private TipoDeUbicacionRepository tipoUbicacionRepository;

        public AgregarUbicacionForm(GenerarPublicacionForm form)
        {
            InitializeComponent();
            this.form = form;
            this.tipoUbicacionRepository = new TipoDeUbicacionRepository();

            ComboBoxFiller<TipoDeUbicacion, decimal>.Fill(cmbTipoUbicacion)
                .KeyAs(tipo => tipo.IdTipoUbicacion)
                .ValueAs(tipo => tipo.Descripcion)
                .With(tipoUbicacionRepository.TodosLosTiposDeUbicacion());
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbFilasAsientos.Checked)
            {
                form.AgregarUbicacion("Fila " + txtFila.Text, txtAsientos.Text, txtPrecio.Text, cmbTipoUbicacion.Text);
            }
            else
            {
                form.AgregarUbicacion("Sin numerar", txtAsientos.Text, txtPrecio.Text, cmbTipoUbicacion.Text);
            }

            this.Close();
            this.Dispose();
        }
    }
}
