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

namespace PalcoNet.Comprar
{
    public partial class ComprarForm : Form
    {
        private Form previousForm;

        public ComprarForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void ComprarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
