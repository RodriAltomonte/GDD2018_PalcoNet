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

namespace PalcoNet.Comprar
{
    public partial class UbicacionesForm : Form
    {
        private string CodPublicacion;
        public UbicacionesForm(string codigo_publicacion)
        {
            InitializeComponent();
            InitializeForm();
            
            CodPublicacion = codigo_publicacion;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
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
                    inputParameters.AddParameter("@monto_total", monto_total);
                    inputParameters.AddParameter("@fecha_compra", fecha_compra);
                    inputParameters.AddParameter("@usuario_cliente_comprador", usuario_cliente_comprador);
                    inputParameters.AddParameter("@tarjeta_comprador", tarjeta_comprador);
                    inputParameters.AddParameter("@cantidad_ubicaciones", cantidad_de_ubicaciones);

                    try
                    {
                        ConnectionFactory.Instance().CreateConnection().ExecuteDataTableStoredProcedure(SpNames.NuevaCompra, inputParameters);
                        MessageBox.Show("Compra realizada exitosamente!");
                    }
                    catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            
                }
            }
           
        }

        #region Initialization
        private void InitializeForm()
        {
            dgvUbicaciones.DataSource = ConnectionFactory.Instance()
                                                         .CreateConnection()
                                                         .ExecuteDataTableSqlQuery(@"SELECT u.fila AS Fila,u.asiento AS Asiento,u.precio AS Precio FROM LOS_DE_GESTION.Ubicacion u 
                                                                                     JOIN LOS_DE_GESTION.Publicacion p 
                                                                                      ON u.cod_publicacion=p.cod_publicacion ");
        }
        #endregion
    }
}
