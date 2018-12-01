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
    public partial class frmBorrarFuncionalidad : Form
    {
        private decimal idRol;
        public frmBorrarFuncionalidad(decimal idRol)
        {
            InitializeComponent();
            this.idRol = idRol;
            DataTable dt = new DataTable();
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dvgFuncionalidadesRol.SelectedCells;

            inputParameters.AddParameter("@idRol",idRol);
            dt = ConnectionFactory.Instance()
                              .CreateConnection()
                              .ExecuteDataTableStoredProcedure(SpNames.FuncionaliadesDeUnRol, inputParameters);

            dvgFuncionalidadesRol.DataSource = dt;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dvgFuncionalidadesRol.SelectedCells;
            try
            {
                foreach (DataGridViewCell cell in cells)
                {
                    inputParameters.AddParameter("@id_rol", idRol);
                    inputParameters.AddParameter("@funcionalidad", decimal.Parse(cell.Value.ToString()));
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BorrarFuncionalidad, inputParameters);

                    inputParameters.RemoveParameters();
                }
                MessageBox.Show("Funcionalidades eliminadas correctamente");
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);
            }
        }
    }
}
