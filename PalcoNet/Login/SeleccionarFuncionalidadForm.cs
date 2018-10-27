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
using PalcoNet.Classes.Repository;

namespace PalcoNet.Login
{
    public partial class SeleccionarFuncionalidadForm : Form, IBackwardableForm, IForwardableForm
    {
        private Form previousForm;
        private FuncionalidadRepository funcionalidadRepository;

        public SeleccionarFuncionalidadForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Backward();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }


        public void ForwardTo(Form nextForm)
        {
            throw new NotImplementedException();
        }

        public void Backward()
        {
            this.Dispose();
            this.Close();
            previousForm.Show();
        }
    }
}
