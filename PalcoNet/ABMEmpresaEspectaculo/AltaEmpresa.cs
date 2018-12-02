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

namespace PalcoNet.ABMEmpresaEspectaculo
{
    public partial class AltaEmpresa : Form
    {
        public AltaEmpresa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!TextFieldUtils.IsAnyFieldEmpty(this)){
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
            inputParameters.AddParameter("@username", StringUtil.GenerateRandomUsername(10));
            inputParameters.AddParameter("@password", StringUtil.GenerateRandomPassword(8));
            inputParameters.AddParameter("@rol", 1);//CAMBIAR ESTO ES SOLO DE PRUEBA
            inputParameters.AddParameter("@razon_social", txtRazonSocial.Text);
            inputParameters.AddParameter("@mail",txtMail.Text);
            inputParameters.AddParameter("@telefono", txtTelefono.Text);
            inputParameters.AddParameter("@direccion_calle", txtDirCalle.Text);
            inputParameters.AddParameter("@nro_calle", decimal.Parse(txtNumero.Text));
            inputParameters.AddParameter("@codigo_postal", txtPostal.Text);
            inputParameters.AddParameter("@ciudad", txtCiudad.Text);
            inputParameters.AddParameter("@cuit", txtCUIT.Text);
            try
            {
                ConnectionFactory.Instance()
                                 .CreateConnection()
                                 .ExecuteDataTableStoredProcedure(SpNames.AltaEmpresa, inputParameters);
                MessageBox.Show(this,"Empresa agregada de forma correcta!","Correcto",MessageBoxButtons.OK);
            }
            catch (StoredProcedureException ex) { MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK); }
            }else{MessageBox.Show("Por favor rellena todos los campos");}
        }

        
    }

}
