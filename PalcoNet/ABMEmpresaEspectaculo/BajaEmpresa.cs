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
                var cuit = StringUtil.FormatCuil(txtCUIT2.Text+txtCUIT1.Text+txtCUIT3.Text);
                var query = StringUtil.FormatEmpresaListado(txtRazonSocial.Text, 
                                                            StringUtil.FormatCuil(txtCUIT2.Text + txtCUIT1.Text + txtCUIT3.Text),
                                                            txtMail.Text);

                DataTable dt = ConnectionFactory.Instance()
                                                .CreateConnection()
                                                .ExecuteDataTableSqlQuery(query);
                dgvEmpresas.AllowUserToAddRows = false;
                dgvEmpresas.ReadOnly = true;
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
