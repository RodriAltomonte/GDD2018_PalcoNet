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

namespace PalcoNet.ABMRubro
{
    public partial class ABMRubroForm : Form
    {
        private Form callerForm;

        public ABMRubroForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
        }
    }
}
