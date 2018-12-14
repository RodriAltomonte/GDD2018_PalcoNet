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

namespace PalcoNet.ABMEmpresaEspectaculo
{
    public partial class BajaEmpresa : Form
    {
        private Form CallerForm;
        public BajaEmpresa(Form caller)
        {
            InitializeComponent();
            CallerForm = caller;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ConnectionFactory.Instance()
                                                .CreateConnection()
                                                .ExecuteDataTableSqlQuery(@"SELECT razon_social,mail,telefono,
                                                                            calle,nro_calle,depto,localidad,
                                                                            codigo_postal,ciudad,cuit,username
                                                                            FROM LOS_DE_GESTION.Empresa
                                                                            WHERE razon_social=" + "'" + txtRazonSocial.Text + "'"
                                                                            + "OR" + "'" + txtRazonSocial.Text + "'" + "IS NULL AND "
                                                                            + "mail=" + "'" + txtMail.Text + "'" + "OR" + "'" + txtMail.Text + "'" +
                                                                            "IS NULL AND cuit=" + "'" + txtCUIT.Text + "'" + "OR" + "'" + txtCUIT.Text + "'" + "IS NULL");
                dgvEmpresas.DataSource = dt;
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
    }
}
