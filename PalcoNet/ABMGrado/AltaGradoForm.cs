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
using TFUtilites;

namespace PalcoNet.ABMGrado
{
    public partial class AltaGradoForm : Form
    {
        private Form callerForm;
        private GradoDePublicacionRepository gradoRepository;

        public AltaGradoForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.gradoRepository = new GradoDePublicacionRepository();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (TextFieldUtils.IsAnyFieldEmpty(this))
            {
                MessageBoxUtil.ShowError("Complete el campo descripción.");
            }
            else
            {
                GradoDePublicacion grado = new GradoDePublicacion(nudCodigo.Value, txtDescripcion.Text, nudPorcentaje.Value);
                try
                {
                    gradoRepository.CrearGradoDePublicacion(grado);
                    MessageBoxUtil.ShowInfo("Grado de publicación creado correctamente.");
                    NavigableFormUtil.BackwardTo(this, callerForm);
                }
                catch (StoredProcedureException ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
