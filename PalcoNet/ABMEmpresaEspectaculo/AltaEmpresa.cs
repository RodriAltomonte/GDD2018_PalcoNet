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
        int HABILITADO;

        public AltaEmpresa(Form caller)
        {
            InitializeComponent();
            callerForm = caller;
            HABILITADO = -1;
        }

        public AltaEmpresa(Form callerForm, Usuario newUser, IAccionPostCreacionUsuario accionPostCreacion)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.newUser = newUser;
            this.accionPostCreacion = accionPostCreacion;
            this.callerForm = callerForm;
            HABILITADO = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = "", password = "";
            if (!TextFieldUtils.IsValidTextField(Ciudad, Localidad)
                || !TextFieldUtils.IsValidNumericField(Verificador1, NroCuit, DigitoVerificador,Piso,Numero, Telefono))
            {
               
            }
            else
            {
                var cuit = Verificador1.Text + NroCuit.Text + DigitoVerificador.Text;
                if (!VerificarCamposNoVacios() && StringUtil.MailUtil.IsValidEmail(Mail.Text))
                {
                    if (TextFieldUtils.CUIT.EsCuitValido(cuit))
                    {
                        StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                        StoredProcedureParameterMap userParameters = new StoredProcedureParameterMap();
                        var fecha_sistema = ConfigurationManager.Instance().GetSystemDateTime();
                        decimal piso;
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
                        inputParameters.AddParameter("@fecha_creacion",fecha_sistema );
                        if (Piso.Text == "")
                        {
                            inputParameters.AddParameter("@nro_piso", DBNull.Value);
                        }
                        else
                        {
                            inputParameters.AddParameter("@nro_piso", decimal.Parse(Piso.Text));
                        }
                        if (Departamento.Text == "")
                        {
                            inputParameters.AddParameter("@depto", DBNull.Value);
                        }
                        else
                        {
                            inputParameters.AddParameter("@depto", Departamento.Text);
                        }
          
                        if (newUser == null)
                        {
                            //Si el usuario es creado desde el abm se genera el usuario y la contraseña de forma aleatoria
                            username = StringUtil.GenerateRandomUsername(Mail.Text,fecha_sistema.Year.ToString());
                            password = StringUtil.GenerateRandomPassword();

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
                            //Crear Usuario
                            userParameters.AddParameter("@username", username);
                            userParameters.AddParameter("@password", password);
                            userParameters.AddParameter("@idRol", 3);
                            userParameters.AddParameter("@intentos_login", HABILITADO);
                            ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableStoredProcedure(SpNames.AltaDeUsuario, userParameters);
                            //Crear Empresa
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

        #region Auxilliary Methods
        public bool VerificarCamposNoVacios()
        {
            if (RazonSocial.Text == "" || Mail.Text == "" || Telefono.Text == "" || DirCalle.Text == ""
                || Numero.Text == "" || Localidad.Text == "" || CodPostal.Text == "" || Ciudad.Text == "" ||
                Verificador1.Text == "" || DigitoVerificador.Text == "" || NroCuit.Text == "")
            {
                MessageBox.Show("Por favor complete los campos obligatorios");
                    return true;
            }else{return false;}
        }
        #endregion

     
    }

}