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
            try
            {
                usuarioRepository.ExisteUsuarioYContrasenia(txtUsername.Text, txtPassword.Text);
            }
            catch (StoredProcedureException ex)
            {
                MessageBox.Show(ex.Message);
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
