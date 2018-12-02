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

namespace PalcoNet.ABMCliente
{
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ConnectionFactory.Instance()
                                                .CreateConnection()
                                                .ExecuteDataTableSqlQuery(@"SELECT nombre,apellido,tipo_documento,
                                                                            numero_documento,cuil,mail,telefono,calle,nro_calle,
                                                                            nro_piso,depto,localidad,codigo_postal,
                                                                            fecha_nacimiento,fecha_creacion,tarjeta,username
                                                                            FROM LOS_DE_GESTION.Cliente
                                                                           "); // FILTRAR RESULTADOS
                dgvClientes.DataSource = dt;
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = dgvClientes.CurrentRow.Cells[16].Value.ToString();

            if (MessageBox.Show("Seguro que desea dar de baja a este cliente?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@username", username);
                try
                {
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BajaCliente, inputParameters);
                    MessageBox.Show("Cliente dado de baja correctamente");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
