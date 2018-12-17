using Classes.DatabaseConnection;
using Classes.Util;
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
using TFUtilites;

namespace PalcoNet.ABMCliente
{
    public partial class BajaCliente : Form
    {
        private Form CallerForm;
        public BajaCliente(Form caller)
        {
            InitializeComponent();
            CallerForm = caller;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsValidTextField(txtApellido, txtNombre) || !TextFieldUtils.IsValidNumericField(txtDNI))
            {
                MessageBox.Show("Por favor revise los datos de entrada");
            }
            else
            {
                if (!TextFieldUtils.AreAllFieldsEmpty(this))
                {
                    try
                    {
                        string query = StringUtil.FormatClienteListado(txtNombre.Text, txtApellido.Text, txtMail.Text, txtDNI.Text);
                        DataTable dt = ConnectionFactory.Instance()
                                                        .CreateConnection()
                                                        .ExecuteDataTableSqlQuery(query);
                        dgvClientes.AllowUserToAddRows = false;
                        dgvClientes.ReadOnly = true;
                        dgvClientes.DataSource = dt;
                    }
                    catch (SqlQueryException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
                }
                else { MessageBox.Show("Introduzca al menos un dato"); }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = dgvClientes.CurrentRow.Cells[0].Value.ToString();

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
    }
}
