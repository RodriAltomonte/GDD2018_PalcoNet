using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Factory.Form;

namespace PalcoNet.Login
{
    public partial class SeleccionarFuncionalidadForm : Form
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
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbFuncionalidades.SelectedItem == null)
            {
                MessageBoxUtil.ShowError("Seleccione una funcionalidad.");
            }
            else
            {
                decimal selectedItemId = ((ComboBoxItem<decimal>)cmbFuncionalidades.SelectedItem).Value;

                NavigableFormUtil.ForwardTo(this, PostLoginFormFactory.CreateForm(selectedItemId, this));
            }

        }
    }
}
