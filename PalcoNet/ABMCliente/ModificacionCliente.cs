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
    public partial class ModificacionCliente : Form
    {
        private string Username;
        private string doc_original = "";
        private string cuil_original = "";
        private Form CallerForm;
        public ModificacionCliente( bool habilitado,
                                    string username,
                                    string nombre,
                                    string apellido,
                                    string tipo_documento,
                                    string nro_documento,
                                    string CUIL,
                                    string mail,
                                    string telefono,
                                    string calle,
                                    string nro_calle,
                                    string nro_piso,
                                    string depto,
                                    string localidad,
                                    string codigo_postal,
                                    string fecha_nacimiento,
                                    string fecha_creacion,
                                    string tarjeta,
                                    Form caller)
        {
            InitializeComponent();
            cbxHabilitado.Checked = habilitado;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            cboTipoDoc.Text = tipo_documento;
            txtNroDocumento.Text = nro_documento;
            StringUtil.ParseCuil(txtCUIL1,txtCUIL2,txtCUIL3,CUIL);
            txtMail.Text = mail;
            txtTelefono.Text = telefono;
            txtCalle.Text = calle;
            txtNumero.Text = nro_calle;
            txtPiso.Text = nro_piso;
            txtDpto.Text = depto;
            txtLocalidad.Text = localidad;
            txtPostal.Text = codigo_postal;
            dtpFechaCreacion.Text = fecha_creacion;
            dtpFechaNacimiento.Text = fecha_nacimiento;
            txtTarjeta.Text = tarjeta;
            Username = username;
            doc_original = nro_documento;
            cuil_original = CUIL;
            CallerForm = caller;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (
  !TextFieldUtils.IsValidNumericField(txtCUIL1, txtCUIL2, txtCUIL3, txtNroDocumento, txtTelefono, txtNumero, txtPiso, txtTarjeta)
           || !TextFieldUtils.IsValidTextField(txtNombre, txtApellido, txtLocalidad))
            {
            }else{ 
                var cuil = txtCUIL1.Text + txtCUIL2.Text + txtCUIL3.Text;
                if (!TextFieldUtils.IsAnyFieldEmpty(this) && StringUtil.MailUtil.IsValidEmail(txtMail.Text) && TextFieldUtils.DatesAreValid(Convert.ToDateTime(dtpFechaNacimiento.Text), Convert.ToDateTime(dtpFechaCreacion.Text)))
                {
                    if (TextFieldUtils.CUIT.EsCuilValido(cuil) && txtCUIL2.Text == txtNroDocumento.Text)
                    {
                        StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                        inputParameters.AddParameter("@nro_documentoOriginal", decimal.Parse(doc_original));
                        inputParameters.AddParameter("@cuil_original", cuil_original);
                        inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
                        inputParameters.AddParameter("@nombre", txtNombre.Text);
                        inputParameters.AddParameter("@apellido", txtApellido.Text);
                        inputParameters.AddParameter("@tipo_documento", cboTipoDoc.Text);
                        inputParameters.AddParameter("@nro_documento", decimal.Parse(txtNroDocumento.Text));
                        inputParameters.AddParameter("@cuil", StringUtil.FormatCuil(cuil));
                        inputParameters.AddParameter("@mail", txtMail.Text);
                        inputParameters.AddParameter("@telefono", txtTelefono.Text);
                        inputParameters.AddParameter("@dir_calle", txtCalle.Text);
                        inputParameters.AddParameter("@nro_calle", decimal.Parse(txtNumero.Text));
                        inputParameters.AddParameter("@nro_piso", decimal.Parse(txtPiso.Text));
                        inputParameters.AddParameter("@depto", txtDpto.Text);
                        inputParameters.AddParameter("@localidad", txtLocalidad.Text);
                        inputParameters.AddParameter("@codigo_postal", txtPostal.Text);
                        inputParameters.AddParameter("@fecha_nacimiento", Convert.ToDateTime(dtpFechaNacimiento.Text));
                        inputParameters.AddParameter("@fecha_de_creacion", Convert.ToDateTime(dtpFechaCreacion.Text));
                        inputParameters.AddParameter("@tarjeta", txtTarjeta.Text);

                        try
                        {
                            ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableStoredProcedure(SpNames.ModificarCliente, inputParameters);
                            MessageBox.Show("Cliente modificado correctamente!");
                        }
                        catch (StoredProcedureException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
                    }
                    else { MessageBox.Show("Por favor verifique el cuil"); }
                }
                
            }
        }

        private void cbxHabilitado_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();

            if (cbxHabilitado.Checked == true)
            {
                inputParameters.AddParameter("@username", Username);
                ConnectionFactory.Instance()
                            .CreateConnection()
                            .ExecuteDataTableStoredProcedure(SpNames.HabilitarCliente, inputParameters);
                MessageBox.Show("Cliente modificado correctamente!");
            }
            else
            {
                inputParameters.AddParameter("@username", Username);
                ConnectionFactory.Instance()
                            .CreateConnection()
                            .ExecuteDataTableStoredProcedure(SpNames.BajaCliente, inputParameters);
                MessageBox.Show("Cliente modificado correctamente!");
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextFieldUtils.CleanAllControls(this);
        }

    }
}
