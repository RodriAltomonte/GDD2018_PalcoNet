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
using PalcoNet.Classes.Form.Interfaces;
using PalcoNet.Classes.Model;
//using PalcoNet.Classes.Session;

namespace PalcoNet.Login
{
    public partial class LoginForm : Form, IForwardableForm
    {
        private UsuarioRepository usuarioRepository;
        private RolRepository rolRepository;

        public LoginForm()
        {
            InitializeComponent();
            usuarioRepository = new UsuarioRepository();
            rolRepository = new RolRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioRepository.ExisteUsuarioYContrasenia(txtUsername.Text, txtPassword.Text);

                if (usuarioRepository.EsUsuarioMigrado(txtUsername.Text))
                {
                    this.ForwardTo(new RegistroUsuario.ModificarPasswordUsuarioForm());
                }
                else
                {
                    //Session.Instance().OpenSession(txtUsername.Text);

                    Rol userRol = rolRepository.IdRolDeUsuario(txtUsername.Text);
                    this.ForwardTo(new SeleccionarFuncionalidadForm(this, userRol));
                }

            }
            catch (StoredProcedureException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarioForm registroForm = new RegistroDeUsuarioForm(this);
            Hide();
            registroForm.Show();
        }

        public void ForwardTo(Form nextForm)
        {            
            this.Hide();
            nextForm.Show();
        }
    }
}
