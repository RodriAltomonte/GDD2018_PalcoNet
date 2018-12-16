using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Session;

namespace PalcoNet.CanjePuntos
{
    public partial class CanjePuntosForm : Form
    {
        private PremioRepository premioRepository;
        private ClienteRepository clienteRepository;
        private Form previousForm;

        public CanjePuntosForm(Form previousForm)
        {
            InitializeComponent();
            this.premioRepository = new PremioRepository();
            this.clienteRepository = new ClienteRepository();
            this.previousForm = previousForm;

            clienteRepository.ValidarVencimientoDePuntosDeCliente(Session.Instance().LoggedUsername);

            ComboBoxFiller<Premio, decimal>.Fill(cmbPremios)
                .KeyAs(premio => premio.IdPremio)
                .ValueAs(premio => premio.Descripcion + " - " + premio.PuntosRequeridos + " puntos requeridos")
                .With(premioRepository.PremiosDisponibles());

            this.ActualizarPuntosYFechaDeVencimiento(premioRepository.PuntosDeUsuario(Session.Instance().LoggedUsername));
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarPremioSeleccionado())
                {
                    decimal idPremio = ((ComboBoxItem<decimal>)cmbPremios.SelectedItem).Value;

                    this.premioRepository.CanjearPremio(Session.Instance().LoggedUsername, idPremio);
                    this.ActualizarPuntosYFechaDeVencimiento(premioRepository.PuntosDeUsuario(Session.Instance().LoggedUsername));

                    MessageBoxUtil.ShowInfo("Item canjeado correctamente.");
                }                
            }
            catch (StoredProcedureException ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }

        }

        #region Auxiliary methods
        private Boolean ValidarPremioSeleccionado()
        {
            if (cmbPremios.SelectedItem == null)
            {
                MessageBoxUtil.ShowError("Seleccione un premio.");
                return false;
            }
            return true;
        }

        private void ActualizarPuntosYFechaDeVencimiento(PuntosDeUsuario puntosDeUsuario)
        {
            txtPuntosValidos.Text = puntosDeUsuario.PuntosDisponibles.ToString();
            txtFechaVencimiento.Text = puntosDeUsuario.FechaDeVencimiento.ToString();
        }
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }
    }
}
