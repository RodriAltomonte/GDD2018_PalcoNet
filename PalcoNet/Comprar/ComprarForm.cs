using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Form.Interfaces;

namespace PalcoNet.Comprar
{
    public partial class ComprarForm : Form, IBackwardableForm
    {
        private Form previousForm;

        public ComprarForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Backward();
        }

        public void Backward()
        {
            this.Dispose();
            this.Close();
            previousForm.Show();
        }

        private void ComprarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
