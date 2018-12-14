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
    public partial class ModificacionGradoForm : Form
    {
        private Form callerForm;
        private GradoDePublicacionRepository gradoRepository;

        public ModificacionGradoForm(Form callerForm)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbModificacion.SelectedItem == null)
            {
                MessageBoxUtil.ShowError("Seleccione un grado de publicación.");                
            }
            else
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBoxUtil.ShowInfo("Complete el campo descripcion.");
                }
                else
                {
                    try
                    {
                        decimal idGradoSeleccionado = ((ComboBoxItem<decimal>)cmbModificacion.SelectedItem).Value;
                        GradoDePublicacion grado = new GradoDePublicacion(idGradoSeleccionado, txtDescripcion.Text, nudPorcentaje.Value);
                        gradoRepository.ModificarGradoDePublicacion(grado);

                        MessageBoxUtil.ShowInfo("Grado de publicación modificado correctamente.");
                        NavigableFormUtil.BackwardTo(this, callerForm);

                    }
                    catch (StoredProcedureException ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        private void cmbModificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradoDePublicacion grado = gradoRepository.BuscarPorId(((ComboBoxItem<decimal>)cmbModificacion.SelectedItem).Value);
            txtDescripcion.Text = grado.Descripcion;
            nudPorcentaje.Value = grado.Porcentaje;
        }

        #region Auxiliary methods
        private void InitializeComboBox()
        {
            ComboBoxFiller<GradoDePublicacion, decimal>.Fill(cmbModificacion)
                .KeyAs(grado => grado.IdGradoDePublicacion)
                .ValueAs(grado => grado.Descripcion + " - " + grado.Porcentaje + "%")
                .With(gradoRepository.TodosLosGradosDePublicacion());
        }
        #endregion


    }
}
