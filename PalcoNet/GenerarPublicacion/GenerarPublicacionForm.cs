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

namespace PalcoNet.GenerarPublicacion
{
    public partial class GenerarPublicacionForm : Form, IBackwardableForm
    {
        private Form previousForm;

        public GenerarPublicacionForm(Form previousForm)
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

    }
}
