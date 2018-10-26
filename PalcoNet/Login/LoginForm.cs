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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usuarioRepository.ExisteUsuarioYContrasenia(lblUsername.Text,lblPassword.Text))
            {
                decimal idRol = rolRepository.IdRolDeUsuario(lblUsername.Text);
            }
            else
            {
                MessageBox.Show("El usuario/contraseña ingresado es inválido.");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarioForm registroForm = new RegistroDeUsuarioForm(this);
            Hide();
            registroForm.Show();
        }


    }
}
