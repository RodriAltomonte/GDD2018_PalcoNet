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
using TFUtilites;
using PalcoNet.Classes.Validator;

namespace PalcoNet.EditarPublicacion
{
    public partial class EditarPublicacionForm : Form
    {
        private PublicacionRepository publicacionRepository;
        private Form callerForm;
        private ControlValidator validator;

        public EditarPublicacionForm(Form callerForm)
        {
            InitializeComponent();
            this.publicacionRepository = new PublicacionRepository();
            this.callerForm = callerForm;
            this.InitializeValidator();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.validator.Validate())
            {
                dgvPublicaciones.DataSource = publicacionRepository.BuscarPublicacionesEditables(Session.Instance().LoggedUsername, txtDescripcion.Text);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPublicaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila");
            }
            else
            {

                NavigableFormUtil.ForwardTo(this, new EditarPublicacionSeleccionada(
               decimal.Parse(dgvPublicaciones.SelectedRows[0].Cells[0].Value.ToString()), this)
               );
            }
           
        }

        public void ActualizarDataGrid()
        {
            dgvPublicaciones.DataSource = publicacionRepository.BuscarPublicacionesEditables(Session.Instance().LoggedUsername, txtDescripcion.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private void InitializeValidator()
        {
            this.validator = new ControlValidator();
            validator.Add(new ControlValidation(txtDescripcion, control => control.Text.Length >= 3, "El campo descripcion es obligatorio y debe escribir al menos tres caracteres."));
        }
    }
}
