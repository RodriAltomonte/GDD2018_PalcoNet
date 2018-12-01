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

namespace PalcoNet.ABMRol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            InitializeComponent();
            DataTable dt = ConnectionFactory.Instance()
                                            .CreateConnection()
                                            .ExecuteDataTableSqlQuery("SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE habilitado=1");
            dgvRoles.DataSource = dt;
                                             
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dgvRoles.SelectedCells;
            try
            {
                foreach (DataGridViewCell cell in cells)
                {
                    inputParameters.AddParameter("@id_Rol", decimal.Parse(cell.Value.ToString()));
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BajaRol, inputParameters);

                    inputParameters.RemoveParameters();
                }
                MessageBox.Show("Roles deshabilitados correctamente!");
            }
            catch (SqlException sqle) { MessageBox.Show(sqle.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
