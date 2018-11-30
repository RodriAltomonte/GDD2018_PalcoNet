using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
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
    public partial class frmAgregarFuncionalidad : Form
    {
        public frmAgregarFuncionalidad()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            dataTable = ConnectionFactory.Instance()
                                         .CreateConnection()
                                         .ExecuteDataTableSqlQuery("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad");
            dvgFuncionalidades.DataSource = dataTable;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dvgFuncionalidades.SelectedCells;
            Funcionalidad nFuncionalidad = new Funcionalidad();
            try
            {
                foreach (DataGridViewCell selected in cells)
                {
                    nFuncionalidad.Id = decimal.Parse(selected.Value.ToString());
                    inputParameters.AddParameter("@rolNombre", txtNombreRol.Text);
                    inputParameters.AddParameter("@funcionalidadRol", nFuncionalidad.Id);
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.AgregarFuncionalidadRol, inputParameters);

                    inputParameters.RemoveParameters();
                }
                MessageBox.Show("Funcionalidades agregadas correctamente!");
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show(sqlE.Message);
            }
        }
    }
}
