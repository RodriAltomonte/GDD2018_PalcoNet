using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.ABMRol
{
    public partial class AltaRol : Form
    {
        Form formularioPadre;
        public AltaRol(Form formularioPadre)
        {
            InitializeComponent();
            this.formularioPadre = formularioPadre;

            /* cargar las funcionalidades existentes */
        }

        private void AltaRol_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
    }
}
