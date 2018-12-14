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
            /*StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            decimal monto_total = 0;
            DateTime fecha_compra = DateTime.Now;
            string usuario_cliente_comprador = Session.Instance().LoggedUsername;
            string tarjeta_comprador = ConnectionFactory.Instance().CreateConnection().ExecuteSingleOutputSqlQuery<string>(@"SELECT tarjeta FROM LOS_DE_GESTION.Cliente 
                                                                                                                            WHERE username="+ "'"+usuario_cliente_comprador+"'");
            decimal cantidad_de_ubicaciones = dgvUbicaciones.SelectedRows.Count;
            if (cantidad_de_ubicaciones <= 0)
            {
                MessageBox.Show("Por favor elige al menos una ubicacion!");
            }
            else
            {

                foreach (DataGridViewRow row in dgvUbicaciones.SelectedRows)
                {
                    monto_total += decimal.Parse(row.Cells[3].Value.ToString());
                    
                }
                inputParameters.AddParameter("@monto_total", monto_total);
                inputParameters.AddParameter("@fecha_compra", fecha_compra);
                inputParameters.AddParameter("@usuario_cliente_comprador", usuario_cliente_comprador);
                inputParameters.AddParameter("@tarjeta_comprador", tarjeta_comprador);
                inputParameters.AddParameter("@cantidad_ubicaciones", cantidad_de_ubicaciones);

                //Actualizar el id_Compra de la ubicacion

                try
                {
                    ConnectionFactory.Instance().CreateConnection().ExecuteDataTableStoredProcedure(SpNames.NuevaCompra, inputParameters);
                    MessageBox.Show("Compra realizada exitosamente!");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }*/

            this.Comprar();
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private void Comprar()
        {
            if (this.ValidarSeleccionDeUbicaciones() && this.TieneTarjeta())
            {
                IList<decimal> idsUbicaciones = this.IdsSeleccionados();
                decimal idCompra = compraRepository.GenerarCompra(this.CrearCompra());
                ubicacionRepository.ActualizarUbicacionesCompradas(idCompra, idsUbicaciones);

                MessageBoxUtil.ShowInfo("Compra realizada correctamente.");
                NavigableFormUtil.BackwardTo(this, callerForm);
            }
        }

        #region Initialization
        private void InitializeForm()
        {
            dgvUbicaciones.DataSource = ubicacionRepository.UbicacionesComprables(decimal.Parse(codPublicacion));
            dgvUbicaciones.Columns[0].Visible = false;
                /*ConnectionFactory.Instance()
                                                         .CreateConnection()
                                                         .ExecuteDataTableSqlQuery(@"SELECT u.fila AS Fila,u.asiento AS Asiento,u.precio AS Precio FROM LOS_DE_GESTION.Ubicacion u 
                                                                                     JOIN LOS_DE_GESTION.Publicacion p 
                                                                                      ON u.cod_publicacion=p.cod_publicacion ");
                 */
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
