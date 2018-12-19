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
using PalcoNet.Classes.Factory;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.Interfaces;
using PalcoNet.Classes.Misc;
using TFUtilites;

namespace PalcoNet.RegistroUsuario
{
    public partial class RegistroDeUsuarioForm : Form
    {
        private Form previousForm;
        private RolRepository rolRepository;
        private UsuarioRepository usuarioRepository;

        public RegistroDeUsuarioForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.rolRepository = new RolRepository();
            this.usuarioRepository = new UsuarioRepository();

            ComboBoxFiller<Rol, decimal>.Fill(cmbRoles)
                .KeyAs(rol => rol.IdRol)
                .ValueAs(rol => rol.Descripcion)
                .With(rolRepository.RolesDeClienteYEmpresa());
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsAnyFieldEmpty(this))
            {
                MessageBox.Show("Por favor completa todos los campos");
            }
            else
            {
            decimal selectedRolId = ((ComboBoxItem<decimal>)cmbRoles.SelectedItem).Value;

            Usuario newUser = UsuarioFactory.CrearNuevoUsuario(selectedRolId, txtUsername.Text, txtPassword.Text);

            try
            {
                IAccionPostCreacionUsuario accionPostCreacion = new VolverALogin(this);
                NavigableFormUtil.ForwardTo(this, ABMClienteEmpresaFormFactory.CrearForm(selectedRolId, this, newUser, accionPostCreacion));
            }
            catch (StoredProcedureException ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }
                
    }
}
