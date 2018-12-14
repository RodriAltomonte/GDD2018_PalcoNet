using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.GenerarRendicionComisiones
{
    /// <summary>
    /// Cuando el cliente hace una compra para una publicacion se debe crear una rendicion de esa compra
    /// rellenando los campos necesarios
    /// </summary>

    public partial class GenerarRendicionForm : Form
    {
        public GenerarRendicionForm()
        {
            InitializeComponent();
           
           DataSet ds = ConnectionFactory.Instance()
                                                     .CreateConnection()
                                                     .ExecuteDataSetSqlQuery("SELECT razon_social FROM LOS_DE_GESTION.Empresa","razon_social");
           cbEmpresas.DisplayMember="razon_social";
           cbEmpresas.DataSource = ds.Tables["razon_social"];

        }

        private void nudCantidadRendicion_ValueChanged(object sender, EventArgs e)
        {
            //Obtengo las compras que se le realizaron a la empresa
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@razon_social",cbEmpresas.Text);
            inputParameters.AddParameter("@cantidad",nudCantidadRendicion.Value);
            dgvClientes.DataSource = ConnectionFactory.Instance()
                                                      .CreateConnection()
                                                      .ExecuteDataTableStoredProcedure(SpNames.ListadoComprasEmpresa,inputParameters);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Obtener compras seleccionadas
            // Primero debo crear una rencion y luego los item rendicion
        }
        

    }
}
