using Classes.DatabaseConnection;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Util.Form;
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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
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
                                                                            fecha_nacimiento,fecha_creacion,tarjeta
                                                                            FROM LOS_DE_GESTION.Cliente
                                                                           "); // ARREGLAR ESTO
                dgvClientes.DataSource = dt;
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            string nombre = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string apellido = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            string tipo_documento = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            string nro_documento = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            string CUIL = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            string mail = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            string telefono = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            string calle = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            string nro_calle = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            string nro_piso = dgvClientes.CurrentRow.Cells[9].Value.ToString();
            string depto = dgvClientes.CurrentRow.Cells[10].Value.ToString();
            string localidad = dgvClientes.CurrentRow.Cells[11].Value.ToString();
            string codigo_postal = dgvClientes.CurrentRow.Cells[12].Value.ToString();
            string fecha_nacimiento = dgvClientes.CurrentRow.Cells[13].Value.ToString();
            string fecha_creacion = dgvClientes.CurrentRow.Cells[14].Value.ToString();
            string tarjeta = dgvClientes.CurrentRow.Cells[15].Value.ToString();
            bool habilitado = ConnectionFactory.Instance()
                                               .CreateConnection()
                                               .ExecuteSingleOutputSqlQuery<bool>(@"SELECT habilitado 
                                                                                   FROM LOS_DE_GESTION.Usuario
                                                                                   WHERE username = (SELECT username FROM
                                                                                                    LOS_DE_GESTION.Cliente 
                                                                                                    WHERE numero_documento="+"'"+nro_documento +"'"+")");
            NavigableFormUtil.ForwardTo(this, new ModificacionCliente(habilitado,
                                                                      nombre,
                                                                      apellido,
                                                                      tipo_documento,
                                                                      nro_documento,
                                                                      CUIL,
                                                                      mail,
                                                                      telefono,
                                                                      calle,
                                                                      nro_calle,
                                                                      nro_piso,
                                                                      depto,
                                                                      localidad,
                                                                      codigo_postal,
                                                                      fecha_nacimiento,
                                                                      fecha_creacion,
                                                                      tarjeta));
           
        }
    }
}
