using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.ABMCliente
{
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
            DataTable dt = ConnectionFactory.Instance()
                                            .CreateConnection()
                                            .ExecuteDataTableSqlQuery("SELECT username FROM LOS_DE_GESTION.Usuario WHERE habilitado=1");
            dgvClientes.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dgvClientes.SelectedCells;
            try
            {
                foreach (DataGridViewCell cell in cells)
                {
                    inputParameters.AddParameter("@username", cell.Value.ToString());
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BajaCliente, inputParameters);
                    inputParameters.RemoveParameters();
                }
                MessageBox.Show("Usuario dado de baja correctamente!");
            }
            catch (SqlException sqle) { MessageBox.Show(sqle.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
