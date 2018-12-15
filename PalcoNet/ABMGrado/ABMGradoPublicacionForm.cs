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
using PalcoNet.Classes.Factory.Form;

namespace PalcoNet.ABMGrado
{
    public partial class ABMGradoPublicacionForm : Form
    {
        private Form callerForm;

        public ABMGradoPublicacionForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new BajaGradoForm(this));
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ModificacionGradoForm(this));
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new AltaGradoForm(this));
        }
    }
}
