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

namespace PalcoNet.ABMCliente
{
    public partial class AltaCliente : Form
    {
        private Form callerForm;
        private Usuario newUser;
        private IAccionPostCreacionUsuario accionPostCreacion = new NoVolverALogin();

        public AltaCliente()
        {
            InitializeComponent();
        }

        public AltaCliente(Form callerForm, Usuario newUser, IAccionPostCreacionUsuario accionPostCreacion) 
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.newUser = newUser;
            this.accionPostCreacion = accionPostCreacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsAnyFieldEmpty(this) && StringUtil.MailUtil.IsValidEmail(txtMail.Text)) //&& StringUtil.IsDateCorrect(dtpFechaCreacion.Text))
            {
               
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
                inputParameters.AddParameter("@id_rol", 2); // 2 Rol Cliente
                inputParameters.AddParameter("@nombre", txtNombre.Text);
                inputParameters.AddParameter("@apellido", txtApellido.Text);
                inputParameters.AddParameter("@tipo_documento", cboTipoDoc.Text);
                inputParameters.AddParameter("@nro_documento", decimal.Parse(txtNroDocumento.Text));
                inputParameters.AddParameter("@cuil", txtCUIL.Text);
                inputParameters.AddParameter("@mail", txtMail.Text);
                inputParameters.AddParameter("@telefono", txtTelefono.Text);
                inputParameters.AddParameter("@direccion_calle", txtCalle.Text);
                inputParameters.AddParameter("@numero_calle", decimal.Parse(txtNumero.Text));
                inputParameters.AddParameter("@numero_piso", decimal.Parse(txtPiso.Text));
                inputParameters.AddParameter("@departamento", txtDpto.Text);
                inputParameters.AddParameter("@localidad", txtLocalidad.Text);
                inputParameters.AddParameter("@codigo_postal", txtPostal.Text);
                inputParameters.AddParameter("@fecha_de_nacimiento", Convert.ToDateTime(dtpFechaNacimiento.Text));
                inputParameters.AddParameter("@fecha_de_creacion", Convert.ToDateTime(dtpFechaCreacion.Text)); // Verificar la fecha con el archivo de configuracion
                inputParameters.AddParameter("@tarjeta", txtTarjeta.Text);

                if (newUser == null)
                {
                    inputParameters.AddParameter("@username", StringUtil.GenerateRandomUsername(10));
                    inputParameters.AddParameter("@password", StringUtil.GenerateRandomPassword(10)); // FALTA ENCRIPTAR 
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
            else { MessageBox.Show("Por favor completa todos los campos y revisa el mail"); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextFieldUtils.CleanAllControls(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
