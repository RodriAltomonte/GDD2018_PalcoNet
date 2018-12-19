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
using PalcoNet.Classes.Validator;


namespace PalcoNet.RegistroUsuario
{
    public partial class RegistroDeUsuarioForm : Form
    {
        private Form previousForm;
        private RolRepository rolRepository;
        private UsuarioRepository usuarioRepository;
        private ControlValidator controlValidator;

        public RegistroDeUsuarioForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.rolRepository = new RolRepository();
            this.usuarioRepository = new UsuarioRepository();
            this.controlValidator = new ControlValidator();
            controlValidator.Add(new ControlValidation(txtPassword, control => control.Text != "", "Ingrese Contraseña"));
            controlValidator.Add(new ControlValidation(txtUsername, control => control.Text != "", "Ingrese Nombre de Usuario"));

            controlValidator.Add(new ControlValidation(cmbRoles, control => ((ComboBox)control).SelectedItem != null, "Complete todos los Campos"));
            ComboBoxFiller<Rol, decimal>.Fill(cmbRoles)
                .KeyAs(rol => rol.IdRol)
                .ValueAs(rol => rol.Descripcion)
                .With(rolRepository.RolesDeClienteYEmpresa());
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (controlValidator.Validate())
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
