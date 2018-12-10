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
using PalcoNet.Classes.Session;
using PalcoNet.Classes.Util.Form;

namespace PalcoNet.EditarPublicacion
{
    public partial class EditarPublicacionForm : Form
    {
        private PublicacionRepository publicacionRepository;

        public EditarPublicacionForm()
        {
            InitializeComponent();
            this.publicacionRepository = new PublicacionRepository();        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPublicaciones.DataSource = publicacionRepository.BuscarPublicacionesEditables(Session.Instance().LoggedUsername, txtDescripcion.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new EditarPublicacionSeleccionada(
                decimal.Parse(dgvPublicaciones.SelectedRows[0].Cells[0].Value.ToString()), this)
                );
        }

        public void ActualizarDataGrid()
        {
            dgvPublicaciones.DataSource = publicacionRepository.BuscarPublicacionesEditables(Session.Instance().LoggedUsername, txtDescripcion.Text);
        }
    }
}
