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

namespace PalcoNet.ABMEmpresaEspectaculo
{
    public partial class ListadoEmpresa : Form
    {
        private Form CallerForm;
        public ListadoEmpresa(Form caller)
        {
            InitializeComponent();
            CallerForm = caller;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsValidTextField(txtRazonSocial)
                || !TextFieldUtils.IsValidNumericField(txtCUIT1, txtCUIT2, txtCUIT3))
            {
                MessageBox.Show("Por favor revise los datos ingresados");
            }
            else
            {
                if (!TextFieldUtils.AreAllFieldsEmpty(this))
                {
                    try
                    {
                        string query = StringUtil.FormatEmpresaListado(txtRazonSocial.Text,
                                                                    StringUtil.FormatCuil(txtCUIT1.Text + txtCUIT2.Text + txtCUIT3.Text),
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
                else { MessageBox.Show("Introduzca al menos un dato"); }
            }
        }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string razon_social = dgvEmpresas.CurrentRow.Cells[0].Value.ToString();
            string mail = dgvEmpresas.CurrentRow.Cells[1].Value.ToString();
            string telefono = dgvEmpresas.CurrentRow.Cells[2].Value.ToString();
            string calle = dgvEmpresas.CurrentRow.Cells[3].Value.ToString();
            string nro_calle = dgvEmpresas.CurrentRow.Cells[4].Value.ToString();
            string depto = dgvEmpresas.CurrentRow.Cells[5].Value.ToString();
            string localidad = dgvEmpresas.CurrentRow.Cells[6].Value.ToString();
            string codigo_postal = dgvEmpresas.CurrentRow.Cells[7].Value.ToString();
            string ciudad = dgvEmpresas.CurrentRow.Cells[8].Value.ToString();
            string ciut = dgvEmpresas.CurrentRow.Cells[9].Value.ToString();
            string username = dgvEmpresas.CurrentRow.Cells[10].Value.ToString();
            bool habilitada = ConnectionFactory.Instance()
                                               .CreateConnection()
                                               .ExecuteSingleOutputSqlQuery<bool>(@"SELECT habilitado 
                                                                                     FROM LOS_DE_GESTION.Usuario    
                                                                                     WHERE username=" + "'" + username + "'");
            NavigableFormUtil.ForwardTo(this, new ModificacionEmpresa(razon_social,
                                                                      mail,
                                                                      telefono,
                                                                      calle,
                                                                      nro_calle,
                                                                      depto,
                                                                      localidad,
                                                                      codigo_postal,
                                                                      ciudad,
                                                                      ciut,
                                                                      username,
                                                                      habilitada,this));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
    }
}
