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
    public partial class DarDeBajaUsuarioForm : Form
    {
        private UsuarioRepository usuarioRepository;
        private Form callerForm;

        public DarDeBajaUsuarioForm(Form callerForm)
        {
            InitializeComponent();
            this.usuarioRepository = new UsuarioRepository();
            this.callerForm = callerForm;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarioRepository.BuscarUsuarios(txtBuscar.Text);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBoxUtil.ShowError("Seleccione un usuario.");
            }
            else
            {
                usuarioRepository.DarDeBajaUnUsuarioPorAdmin(txtUsuarioSeleccionado.Text);
                MessageBoxUtil.ShowInfo("Usuario dado de baja correctamente.");
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                txtUsuarioSeleccionado.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
