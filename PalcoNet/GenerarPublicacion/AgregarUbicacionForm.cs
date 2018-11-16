using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.GenerarPublicacion
{
    public partial class AgregarUbicacionForm : Form
    {
        public AgregarUbicacionForm()
        {
            InitializeComponent();
        }

        private void rdbFilasAsientos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilasAsientos.Checked)
            {
                lblFila.Visible = true;
                lblAsientos.Visible = true;
                txtAsientos.Visible = true;
                txtFila.Visible = true;                
            }
        }

        private void rdbSinNumerar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSinNumerar.Checked)
            {
                lblFila.Visible = false;
                lblAsientos.Visible = false;
                txtAsientos.Visible = false;
                txtFila.Visible = false;
            }
        }
    }
}
