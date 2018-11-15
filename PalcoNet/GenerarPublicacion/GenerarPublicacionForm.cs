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
using PalcoNet.Classes.Model;

namespace PalcoNet.GenerarPublicacion
{
    public partial class GenerarPublicacionForm : Form
    {
        private Form previousForm;
        private RubroRepository rubroRepository;
        private GradoDePublicacionRepository gradoRepository;
        private EstadoDePublicacionRepository estadoRepository;

        public GenerarPublicacionForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.rubroRepository = new RubroRepository();
            this.gradoRepository = new GradoDePublicacionRepository();
            this.estadoRepository = new EstadoDePublicacionRepository();

            this.InitializeControls();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        #region Auxiliary methods
        private void InitializeControls() 
        {
            ComboBoxFiller<Rubro, decimal>.Fill(cmbRubro)
                .KeyAs(rubro => rubro.IdRubro)
                .ValueAs(rubro => rubro.Descripcion)
                .With(rubroRepository.TodosLosRubros());

            ComboBoxFiller<GradoDePublicacion, decimal>.Fill(cmbGrado)
                .KeyAs(grado => grado.IdGradoDePublicacion)
                .ValueAs(grado => grado.Descripcion + " - " + grado.Porcentaje.ToString() + "%")
                .With(gradoRepository.TodosLosGradosDePublicacion());

            ComboBoxFiller<EstadoDePublicacion, decimal>.Fill(cmbEstado)
                .KeyAs(estado => estado.IdEstadoDePublicacion)
                .ValueAs(estado => estado.Descripcion)
                .With(estadoRepository.TodosLosEstadosDePublicacion());
        }
        #endregion

    }
}
