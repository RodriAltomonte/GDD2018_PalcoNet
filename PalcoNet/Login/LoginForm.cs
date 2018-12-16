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
using PalcoNet.RegistroUsuario;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Session;

namespace PalcoNet.Login
{
    public partial class LoginForm : Form
    {
        private UsuarioRepository usuarioRepository;
        private RolRepository rolRepository;

        public LoginForm()
        {
            InitializeComponent();
            usuarioRepository = new UsuarioRepository();
            rolRepository = new RolRepository();

            Session.Instance().CloseSession();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioRepository.ExisteUsuarioYContrasenia(txtUsername.Text, txtPassword.Text);

                if (usuarioRepository.EsUsuarioMigrado(txtUsername.Text))
                {
                    MessageBoxUtil.ShowInfo("Debe modificar su contraseña.");
                    NavigableFormUtil.ForwardTo(this, new RegistroUsuario.ModificarPasswordUsuarioForm(txtUsername.Text, this));
                }
                else
                {
                    Session.Instance().OpenSession(txtUsername.Text);

                    Rol userRol = rolRepository.IdRolDeUsuario(txtUsername.Text);
                    NavigableFormUtil.ForwardTo(this, new SeleccionarFuncionalidadForm(this, userRol));
                }

            }
            catch (StoredProcedureException ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new RegistroDeUsuarioForm(this));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
