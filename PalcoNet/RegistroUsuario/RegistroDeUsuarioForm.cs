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
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Factory.Form;

namespace PalcoNet.RegistroUsuario
{
    public partial class RegistroDeUsuarioForm : Form
    {
        private Form callerForm;

        public RegistroDeUsuarioForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
                
    }
}
