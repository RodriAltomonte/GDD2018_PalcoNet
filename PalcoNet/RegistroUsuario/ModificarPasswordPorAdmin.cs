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
    public partial class ModificarPasswordPorAdmin : Form
    {
        private UsuarioRepository usuarioRepository;

        public ModificarPasswordPorAdmin()
        {
            InitializeComponent();
            usuarioRepository = new UsuarioRepository();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarioRepository.BuscarUsuarios(txtBuscar.Text);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            txtUsuarioSeleccionado.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un usuario.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                usuarioRepository.CambiarPassword(txtUsuarioSeleccionado.Text, txtNuevoPass.Text);
            }
        }
    }
}
