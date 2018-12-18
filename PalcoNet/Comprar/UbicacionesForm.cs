using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Configuration;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Model;

namespace PalcoNet.Comprar
{
    public partial class UbicacionesForm : Form
    {
        private Form callerForm;
        private string codPublicacion;
        private UbicacionRepository ubicacionRepository;
        private CompraRepository compraRepository;
        private ClienteRepository clienteRepository;

        public UbicacionesForm(Form callerForm, string codigoPublicacion)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.codPublicacion = codigoPublicacion;
            this.ubicacionRepository = new UbicacionRepository();
            this.compraRepository = new CompraRepository();
            this.clienteRepository = new ClienteRepository();
            InitializeForm();

          
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (this.ValidarSeleccionDeUbicaciones() && this.TieneTarjeta())
            {
                clienteRepository.ValidarVencimientoDePuntosDeCliente(Session.Instance().LoggedUsername);

                IList<decimal> idsUbicaciones = this.IdsSeleccionados();
                decimal idCompra = compraRepository.GenerarCompra(this.CrearCompra(), this.CalcularPuntosGanados());

                ubicacionRepository.ActualizarUbicacionesCompradas(idCompra, idsUbicaciones);

                MessageBoxUtil.ShowInfo("Compra realizada correctamente.");
                NavigableFormUtil.BackwardTo(this, callerForm);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        #region Initialization
        private void InitializeForm()
        {
            dgvUbicaciones.DataSource = ubicacionRepository.UbicacionesComprables(decimal.Parse(codPublicacion));
            dgvUbicaciones.Columns[0].Visible = false;//Ocultar ids de ubicacion
            dgvUbicaciones.Columns[5].Visible = false;//Ocultar puntos de cliente
        }
        #endregion

        #region Auxiliary methods
        private IList<decimal> IdsSeleccionados()
        {
            return DataGridViewUtil.ListOfRowCells<decimal>(dgvUbicaciones.SelectedRows, 0);
        }

        private IList<decimal> PreciosSeleccionados()
        {
            return DataGridViewUtil.ListOfRowCells<decimal>(dgvUbicaciones.SelectedRows, 3);
        }

        private bool TieneTarjeta()
        {
            if (!clienteRepository.ClienteTieneTarjeta(Session.Instance().LoggedUsername))
            {
                MessageBoxUtil.ShowError("No se puede realizar la compra, no tiene una tarjeta asociada.");
                NavigableFormUtil.ForwardTo(this, new AsociarTarjeta(this));
                return false;
            }
            return true;
        }

        private Compra CrearCompra()
        {
            Compra nuevaCompra = new Compra();
            nuevaCompra.FechaDeCompra = ConfigurationManager.Instance().GetSystemDateTime();
            nuevaCompra.UsuarioComprador = Session.Instance().LoggedUsername;
            nuevaCompra.CantidadUbicaciones = dgvUbicaciones.SelectedRows.Count;
            nuevaCompra.MontoTotal = this.PreciosSeleccionados().Sum();
            nuevaCompra.TarjetaComprador = clienteRepository.TarjetaDeCliente(nuevaCompra.UsuarioComprador);
            return nuevaCompra;
        }

        private int CalcularPuntosGanados()
        {
            return DataGridViewUtil.ListOfRowCells<int>(dgvUbicaciones.SelectedRows, 5).Sum();
        }

        private bool ValidarSeleccionDeUbicaciones()
        {
            if (dgvUbicaciones.SelectedRows.Count <= 0)
            {
                MessageBoxUtil.ShowError("Seleccione al menos una ubicación.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
