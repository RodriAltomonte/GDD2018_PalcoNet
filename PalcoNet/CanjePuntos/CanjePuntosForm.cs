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

namespace PalcoNet.CanjePuntos
{
    public partial class CanjePuntosForm : Form
    {
        private PremioRepository premioRepository;
        private ClienteRepository clienteRepository;

        public CanjePuntosForm()
        {
            InitializeComponent();
            this.premioRepository = new PremioRepository();
            this.clienteRepository = new ClienteRepository();

            //TODO reemplazar string
            clienteRepository.ValidarVencimientoDePuntosDeCliente("username");

            ComboBoxFiller<Premio, decimal>.Fill(cmbPremios)
                .KeyAs(premio => premio.IdPremio)
                .ValueAs(premio => premio.Descripcion + " - " + premio.PuntosRequeridos + " puntos requeridos")
                .With(premioRepository.PremiosDisponibles());
            //TODO reemplazar string
            this.ActualizarPuntosYFechaDeVencimiento(premioRepository.PuntosDeUsuario("username"));
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarPremioSeleccionado())
                {
                    //TODO reemplazar string
                    decimal idPremio = ((ComboBoxItem<decimal>)cmbPremios.SelectedItem).Value;

                    this.premioRepository.CanjearPremio("username", idPremio);
                    this.ActualizarPuntosYFechaDeVencimiento(premioRepository.PuntosDeUsuario("username"));

                    MessageBox.Show("Item canjeado correctamente.", "", MessageBoxButtons.OK);    
                }                
            }
            catch (StoredProcedureException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        #region Auxiliary methods
        private Boolean ValidarPremioSeleccionado()
        {
            if (cmbPremios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un premio.", "Error", MessageBoxButtons.OK);
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
    }
}
