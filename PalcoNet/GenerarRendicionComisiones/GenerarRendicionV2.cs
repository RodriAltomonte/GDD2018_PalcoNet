using Classes.DatabaseConnection;
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
    public partial class GenerarRendicionV2 : Form
    {
        public GenerarRendicionV2()
        {
            InitializeComponent();
            var query = "SELECT TOP " + nudCantidadRendicion.Value.ToString() + " * FROM LOS_DE_GESTION.Compra";
            dgvClientes.DataSource = ConnectionFactory.Instance()
                                                      .CreateConnection()
                                                      .ExecuteDataTableSqlQuery(query);
           
           DataSet ds = ConnectionFactory.Instance()
                                                     .CreateConnection()
                                                     .ExecuteDataSetSqlQuery("SELECT razon_social FROM LOS_DE_GESTION.Empresa","razon_social");
           cbEmpresas.DisplayMember="razon_social";
           cbEmpresas.DataSource = ds.Tables["razon_social"];

        }

        private void nudCantidadRendicion_ValueChanged(object sender, EventArgs e)
        {
            var query = "SELECT TOP " + nudCantidadRendicion.Value.ToString() + " * FROM LOS_DE_GESTION.Compra";
            dgvClientes.DataSource = ConnectionFactory.Instance()
                                                      .CreateConnection()
                                                      .ExecuteDataTableSqlQuery(query);
        }
    }
}
