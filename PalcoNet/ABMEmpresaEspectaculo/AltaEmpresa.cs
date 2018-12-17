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

namespace PalcoNet.ABMEmpresaEspectaculo
{
    public partial class AltaEmpresa : Form
    {
        private Form callerForm;
        private Usuario newUser;
        private IAccionPostCreacionUsuario accionPostCreacion = new NoVolverALogin();

        public AltaEmpresa(Form caller)
        {
            InitializeComponent();
            callerForm = caller;
        }

        public AltaEmpresa(Form callerForm, Usuario newUser, IAccionPostCreacionUsuario accionPostCreacion)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.newUser = newUser;
            this.accionPostCreacion = accionPostCreacion;
            this.callerForm = callerForm;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = "", password = "";
            if (!TextFieldUtils.IsValidTextField(Ciudad, Localidad)
                || !TextFieldUtils.IsValidNumericField(Verificador1, NroCuit, DigitoVerificador, Piso, Numero, Telefono))
            {
               
            }
            else
            {
                var cuit = Verificador1.Text + NroCuit.Text + DigitoVerificador.Text;
                if (!TextFieldUtils.IsAnyFieldEmpty(this) && StringUtil.MailUtil.IsValidEmail(Mail.Text))
                {
                    if (TextFieldUtils.CUIT.EsCuitValido(cuit))
                    {
                        StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                        inputParameters.AddParameter("@habilitado", true);
                        inputParameters.AddParameter("@rol", 3);//3 rol Empresa
                        inputParameters.AddParameter("@razon_social", RazonSocial.Text);
                        inputParameters.AddParameter("@mail", Mail.Text);
                        inputParameters.AddParameter("@telefono", Telefono.Text);
                        inputParameters.AddParameter("@direccion_calle", DirCalle.Text);
                        inputParameters.AddParameter("@nro_calle", decimal.Parse(Numero.Text));
                        inputParameters.AddParameter("@codigo_postal", CodPostal.Text);
                        inputParameters.AddParameter("@ciudad", Ciudad.Text);
                        inputParameters.AddParameter("@cuit", StringUtil.FormatCuil(cuit));
                        inputParameters.AddParameter("@fecha_creacion", ConfigurationManager.Instance().GetSystemDateTime());

                        if (newUser == null)
                        {
                            username = StringUtil.GenerateRandomUsername(10);
                            password = StringUtil.GenerateRandomPassword(10);

                            inputParameters.AddParameter("@username",username );
                            inputParameters.AddParameter("@password", password);
                        }
                        else
                        {
                            username = newUser.Username;
                            password = newUser.Password;
                            inputParameters.AddParameter("@username", newUser.Username);
                            inputParameters.AddParameter("@password", newUser.Password);
                        }

                        try
                        {
                            ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableStoredProcedure(SpNames.AltaEmpresa, inputParameters);

                            MessageBox.Show(this, @"Empresa agregada de forma correcta!Puede ingresar al sistema con el usuario: "+username+" password:"+password, "Correcto", MessageBoxButtons.OK);
                            accionPostCreacion.Do(this);
                        }
                        catch (StoredProcedureException ex) { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK); }
                    }
                    else { MessageBox.Show("Verifica el CUIT"); }
                }
                else { MessageBox.Show("Por favor rellena todos los campos"); }
            }
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

}/*

            }else{MessageBox.Show("Por favor rellena todos los campos y comprueba el mail");}
            }else{MessageBox.Show("Por favor rellena todos los campos");}
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
*/