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
using PalcoNet.Classes.Session;

namespace PalcoNet.RegistroUsuario
{
    public partial class ModificarPasswordUsuarioForm : Form
    {
        private UsuarioRepository usuarioRepository;
        private string usuarioAModificar;
        private Form callerForm;

        public ModificarPasswordUsuarioForm(string usuarioAModificar)
        {
            InitializeComponent();
            this.usuarioRepository = new UsuarioRepository();
            this.usuarioAModificar = usuarioAModificar;
        }

        public ModificarPasswordUsuarioForm(Form previousForm)
        {
            InitializeComponent();
            this.usuarioRepository = new UsuarioRepository();
            this.usuarioAModificar = Session.Instance().LoggedUsername;
        }

        private void btnModificarPassword_Click(object sender, EventArgs e)
        {
            if (this.ValidarPasswordNoVacio())
            {
                if (this.ValidarPasswordNuevo())
                {
                    usuarioRepository.CambiarPassword(Session.Instance().LoggedUsername, txtNuevoPassword.Text);
                    if (usuarioRepository.EsUsuarioMigrado(Session.Instance().LoggedUsername))
                    {
                        usuarioRepository.ActualizarUsuarioMigrado(Session.Instance().LoggedUsername);
                    }
                    Session.Instance().CloseSession();
                    MessageBoxUtil.ShowInfo("Contraseña modificada correctamente. Acceda nuevamente.");
                    NavigableFormUtil.BackwardTo(this, new Login.LoginForm());
                }
            }

        }

        #region Auxiliary methods
        private Boolean ValidarPasswordNoVacio() 
        {
            if (txtNuevoPassword.Text == "" || txtConfirmarPassword.Text == "")
            {
                MessageBoxUtil.ShowError("Las contraseñas ingresadas no coinciden.");
                return false;
            }
            return true;
        }

        private Boolean ValidarPasswordNuevo() 
        {
            if (!txtNuevoPassword.Text.Equals(txtConfirmarPassword.Text))
            {
                MessageBoxUtil.ShowError("Las contraseñas ingresadas no coinciden.");
                return false;
            }
            return true;

        }
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
