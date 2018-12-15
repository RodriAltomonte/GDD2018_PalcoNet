using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
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
        private Form CallerForm;
        public ListadoClientes(Form caller)
        {
            InitializeComponent();
            CallerForm = caller;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            decimal dni;
            decimal.TryParse(txtDNI.Text, out dni);
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@nombre", txtNombre.Text);
            inputParameters.AddParameter("@apellido", txtApellido.Text);
            inputParameters.AddParameter("@dni",dni);
            inputParameters.AddParameter("@mail", txtMail.Text);
            try
            {
                DataTable dt = ConnectionFactory.Instance()
                                                .CreateConnection()
                                                .ExecuteDataTableStoredProcedure(SpNames.ListadoClientes,inputParameters); 
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
            string username = dgvClientes.CurrentRow.Cells[16].Value.ToString();
            bool habilitado = ConnectionFactory.Instance()
                                               .CreateConnection()
                                               .ExecuteSingleOutputSqlQuery<bool>(@"SELECT habilitado 
                                                                                   FROM LOS_DE_GESTION.Usuario
                                                                                   WHERE username ="+"'"+username+"'");
            NavigableFormUtil.ForwardTo(this, new ModificacionCliente(habilitado,
                                                                      username,
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
    }
}
