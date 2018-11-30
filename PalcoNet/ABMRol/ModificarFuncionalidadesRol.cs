using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Util.Form;

namespace PalcoNet.ABMRol
{
    public partial class ModificarFuncionalidadesRol : Form
    {
        public ModificarFuncionalidadesRol()
        {
            InitializeComponent();
        }

        private void btnAddFuncionalidad_Click(object sender, EventArgs e)
        {
            new frmAgregarFuncionalidad().Show();
        }

        private void btnDelFuncionalidad_Click(object sender, EventArgs e)
        {
            //new frmBorrarFuncionalidad().Show();
        }

      
    }
}
