using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.CustomException;

namespace PalcoNet.ABMGrado
{
    public partial class BajaGradoForm : Form
    {
        private Form callerForm;
        private GradoDePublicacionRepository gradoRepository;

        public BajaGradoForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.gradoRepository = new GradoDePublicacionRepository();
            this.InitializeComboBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cmbBaja.SelectedItem == null)
            {
                MessageBoxUtil.ShowError("Seleccione un grado de publicación.");
            }
            else
            {
                try
                {
                    decimal idGradoSeleccionado = ((ComboBoxItem<decimal>)cmbBaja.SelectedItem).Value;
                    gradoRepository.EliminarGradoDePublicacion(idGradoSeleccionado);
                    MessageBoxUtil.ShowInfo("Grado de publicacion eliminado correctamente.");
                    NavigableFormUtil.BackwardTo(this, callerForm);
                }
                catch (StoredProcedureException ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
        }

        #region Auxiliary methods
        private void InitializeComboBox()
        {
            ComboBoxFiller<GradoDePublicacion, decimal>.Fill(cmbBaja)
                .KeyAs(grado => grado.IdGradoDePublicacion)
                .ValueAs(grado => grado.Descripcion + " - " + grado.Porcentaje + "%")
                .With(gradoRepository.TodosLosGradosDePublicacion());
        }
        #endregion
    }
}
