using Classes.DatabaseConnection;
using Classes.Util;
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
using TFUtilites;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Interfaces;
using PalcoNet.Classes.Misc;
using Classes.Configuration;

namespace PalcoNet.ABMCliente
{
    public partial class AltaCliente : Form
    {
        private Form CallerForm;
        private Usuario newUser;
        private IAccionPostCreacionUsuario accionPostCreacion = new NoVolverALogin();

        public AltaCliente(Form caller)
        {
            InitializeComponent();
            CallerForm = caller;
        }

        public AltaCliente(Form callerForm, Usuario newUser, IAccionPostCreacionUsuario accionPostCreacion) 
        {
            InitializeComponent();
            CallerForm = callerForm;
            this.newUser = newUser;
            this.accionPostCreacion = accionPostCreacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //VERIFICAR DATOS DE ENTRADA
            var cuil = txtCUIT1.Text + txtCUIT2.Text + txtCUIT3.Text;
            if (!TextFieldUtils.IsAnyFieldEmpty(this) && StringUtil.MailUtil.IsValidEmail(txtMail.Text))
            {
                if (TextFieldUtils.CUIT.EsCuilValido(cuil))
                {
                    StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                    inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
                    inputParameters.AddParameter("@id_rol", 2); // 2 Rol Cliente
                    inputParameters.AddParameter("@nombre", txtNombre.Text);
                    inputParameters.AddParameter("@apellido", txtApellido.Text);
                    inputParameters.AddParameter("@tipo_documento", cboTipoDoc.Text);
                    inputParameters.AddParameter("@nro_documento", decimal.Parse(txtNroDocumento.Text));
                    inputParameters.AddParameter("@cuil", StringUtil.FormatCuil(cuil));
                    inputParameters.AddParameter("@mail", txtMail.Text);
                    inputParameters.AddParameter("@telefono", txtTelefono.Text);
                    inputParameters.AddParameter("@direccion_calle", txtCalle.Text);
                    inputParameters.AddParameter("@numero_calle", decimal.Parse(txtNumero.Text));
                    inputParameters.AddParameter("@numero_piso", decimal.Parse(txtPiso.Text));
                    inputParameters.AddParameter("@departamento", txtDpto.Text);
                    inputParameters.AddParameter("@localidad", txtLocalidad.Text);
                    inputParameters.AddParameter("@codigo_postal", txtPostal.Text);
                    inputParameters.AddParameter("@fecha_de_nacimiento", Convert.ToDateTime(dtpFechaNacimiento.Text));
                    inputParameters.AddParameter("@fecha_de_creacion", ConfigurationManager.Instance().GetSystemDateTime());
                    inputParameters.AddParameter("@tarjeta", txtTarjeta.Text);

                    if (newUser == null)
                    {
                        inputParameters.AddParameter("@username", StringUtil.GenerateRandomUsername(10));
                        inputParameters.AddParameter("@password", StringUtil.GenerateRandomPassword(10));
                    }
                    else
                    {
                        inputParameters.AddParameter("@username", newUser.Username);
                        inputParameters.AddParameter("@password", newUser.Password);
                    }

                    try
                    {
                        ConnectionFactory.Instance()
                                         .CreateConnection()
                                         .ExecuteDataTableStoredProcedure(SpNames.AltaCliente, inputParameters);
                        MessageBoxUtil.ShowInfo("Cliente agreagado exitosamente!");

                        accionPostCreacion.Do(this);
                    }
                    catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("Comprueba el cuil!"); }
            }
            else { MessageBox.Show("Por favor completa todos los campos y reviselos"); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextFieldUtils.CleanAllControls(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
        
    }
}
