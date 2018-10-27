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
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Model;

namespace PalcoNet.Login
{
    public partial class SeleccionarFuncionalidadForm : Form, IBackwardableForm, IForwardableForm
    {
        private Form previousForm;
        private FuncionalidadRepository funcionalidadRepository;
        private Rol userRol;

        public SeleccionarFuncionalidadForm(Form previousForm, Rol userRol)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.userRol = userRol;

            funcionalidadRepository = new FuncionalidadRepository();
            ComboBoxFiller<Funcionalidad, decimal>.Fill(cmbFuncionalidades)
                .KeyAs(funcionalidad => funcionalidad.Id)
                .ValueAs(funcionalidad => funcionalidad.Descripcion)
                .With(funcionalidadRepository.FuncionalidadesDeUnRol(userRol.IdRol));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Backward();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbFuncionalidades.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una funcionalidad.");
            }


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
