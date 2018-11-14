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

namespace PalcoNet.RegistroUsuario
{
    public partial class ModificarPasswordUsuarioForm : Form
    {
        private UsuarioRepository usuarioRepository;
        private string usuarioAModificar;

        public ModificarPasswordUsuarioForm(string usuarioAModificar)
        {
            InitializeComponent();
            this.usuarioRepository = new UsuarioRepository();
            this.usuarioAModificar = usuarioAModificar;
        }

        private void btnModificarPassword_Click(object sender, EventArgs e)
        {
            if (this.ValidarPasswordNoVacio())
            {
                if (this.ValidarPasswordNuevo())
                {
                    usuarioRepository.CambiarPassword(usuarioAModificar, txtNuevoPassword.Text);
                    if (usuarioRepository.EsUsuarioMigrado(usuarioAModificar))
                    {
                        usuarioRepository.ActualizarUsuarioMigrado(usuarioAModificar);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Complete ambos campos.", "Error", MessageBoxButtons.OK);
            }

        }

        private Boolean ValidarPasswordNoVacio() 
        {
            return txtNuevoPassword.Text != "" && txtConfirmarPassword.Text != "";
        }

        private Boolean ValidarPasswordNuevo() 
        {
            return txtNuevoPassword.Text.Equals(txtConfirmarPassword.Text);        
        }
    }
}
