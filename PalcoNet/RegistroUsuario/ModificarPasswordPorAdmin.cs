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

namespace PalcoNet.RegistroUsuario
{
    public partial class ModificarPasswordPorAdmin : Form
    {
        private UsuarioRepository usuarioRepository;
        private Form callerForm;

        public ModificarPasswordPorAdmin(Form callerForm)
        {
            InitializeComponent();
            usuarioRepository = new UsuarioRepository();
            this.callerForm = callerForm;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarioRepository.BuscarUsuarios(txtBuscar.Text);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                txtUsuarioSeleccionado.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un usuario.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (txtNuevoPass.Text.Equals(txtConfirmar.Text))
                {
                    usuarioRepository.CambiarPassword(txtUsuarioSeleccionado.Text, txtNuevoPass.Text);
                    MessageBoxUtil.ShowInfo("Contraseña modificada correctamente.");                    
                }
                else
                {
                    MessageBoxUtil.ShowError("Las contraseñas no coinciden.");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuarioSeleccionado.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
