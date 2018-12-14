using PalcoNet.Classes.Util.Form;
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
    public partial class ABMRolSelectionForm : Form
    {
        private Form callerForm;
        public ABMRolSelectionForm(Form CallerForm)
        {
            InitializeComponent();
            callerForm = CallerForm;
        }
        public ABMRolSelectionForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMRol.AltaRol());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMRol.SeleccionRol());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this,callerForm);
        }
    }
}
