using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
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

namespace PalcoNet.ABMEmpresaEspectaculo
{
    public partial class BajaEmpresa : Form
    {
        public BajaEmpresa()
        {
            InitializeComponent();
            try
            {
                DataTable dt = ConnectionFactory.Instance()
                                                .CreateConnection()
                                                .ExecuteDataTableSqlQuery(@"SELECT razon_social,mail,telefono,
                                                                            calle,nro_calle,depto,localidad,
                                                                            codigo_postal,ciudad,cuit,username
                                                                            FROM LOS_DE_GESTION.Empresa
                                                                            WHERE razon_social=" + "'" + txtRazonSocial.Text + "'"); // ARREGLAR ESTO
                dgvEmpresas.DataSource = dt;
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
        }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = dgvEmpresas.CurrentRow.Cells[10].Value.ToString();

            if (MessageBox.Show("Seguro que desea dar de baja a esta empresa?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@username", username);
                try
                {
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BajaEmpresa, inputParameters);
                    MessageBox.Show("Empresa dada de baja correctamente");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
