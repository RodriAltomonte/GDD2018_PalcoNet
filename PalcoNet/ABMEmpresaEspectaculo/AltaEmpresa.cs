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
            if(!TextFieldUtils.IsAnyFieldEmpty(this) && StringUtil.MailUtil.IsValidEmail(txtMail.Text)){
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
            inputParameters.AddParameter("@rol", 3);//3 rol Empresa
            inputParameters.AddParameter("@razon_social", txtRazonSocial.Text);
            inputParameters.AddParameter("@mail",txtMail.Text);
            inputParameters.AddParameter("@telefono", txtTelefono.Text);
            inputParameters.AddParameter("@direccion_calle", txtDirCalle.Text);
            inputParameters.AddParameter("@nro_calle", decimal.Parse(txtNumero.Text));
            inputParameters.AddParameter("@codigo_postal", txtPostal.Text);
            inputParameters.AddParameter("@ciudad", txtCiudad.Text);
            inputParameters.AddParameter("@cuit", txtCUIT.Text);

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
                                 .ExecuteDataTableStoredProcedure(SpNames.AltaEmpresa, inputParameters);
                              
                MessageBox.Show(this,"Empresa agregada de forma correcta!","Correcto",MessageBoxButtons.OK);
                accionPostCreacion.Do(this);
            }
            catch (StoredProcedureException ex) { MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK); }
            }else{MessageBox.Show("Por favor rellena todos los campos");}
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