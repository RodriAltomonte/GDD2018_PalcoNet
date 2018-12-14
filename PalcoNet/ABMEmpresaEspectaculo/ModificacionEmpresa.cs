using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Session;
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
    public partial class ModificacionEmpresa : Form
    {
        private static string Username = "";
        private static string CUIT = "";
        private Form CallerForm;
        
        public ModificacionEmpresa(string razon_social,
                                   string mail,
                                   string telefono,
                                   string calle,
                                   string nro_calle,
                                   string depto,
                                   string localidad,
                                   string codigo_postal,
                                   string ciudad,
                                   string ciut,
                                   string username,
                                   bool habilitada,
                                   Form callerForm)
                                    
        {
            Username = username;
            CUIT = ciut;

            InitializeComponent();
            txtRazonSocial.Text = razon_social;
            txtMail.Text = mail;
            txtTelefono.Text = telefono;
            txtDirCalle.Text = calle;
            txtNumero.Text = nro_calle;
            txtDpto.Text = depto;
            txtLocalidad.Text = localidad;
            txtPostal.Text = codigo_postal;
            txtCiudad.Text = ciudad;
            txtCUIT.Text = ciut;
            cbxHabilitado.Checked = habilitada;

            CallerForm = callerForm;
            
        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsAnyFieldEmpty(this))
            {
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@cuitOriginal", CUIT);
                inputParameters.AddParameter("@razon_social", txtRazonSocial.Text);
                inputParameters.AddParameter("@mail", txtMail.Text);
                inputParameters.AddParameter("@telefono", decimal.Parse(txtTelefono.Text));
                inputParameters.AddParameter("@direccion_calle", txtDirCalle.Text);
                inputParameters.AddParameter("@numero_calle", decimal.Parse(txtNumero.Text));
                inputParameters.AddParameter("@nro_piso", decimal.Parse(txtPiso.Text));
                inputParameters.AddParameter("@depto", txtDpto.Text);
                inputParameters.AddParameter("@localidad", txtLocalidad.Text);
                inputParameters.AddParameter("@cod_postal", txtPostal.Text);
                inputParameters.AddParameter("@ciudad", txtCiudad.Text);
                inputParameters.AddParameter("@cuit", txtCUIT.Text);
                try
                {
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.ModificarEmpresa, inputParameters);
                    MessageBox.Show("La empresa fue modificada correctamente!");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Por favor completa todos los campos"); }
        }

        private void cbxHabilitado_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();

            if (cbxHabilitado.Checked == true)
            {
                inputParameters.AddParameter("@username", Username);
                ConnectionFactory.Instance()
                            .CreateConnection()
                            .ExecuteDataTableStoredProcedure(SpNames.HabilitarEmpresa, inputParameters);
                MessageBox.Show("Empresa modificada correctamente!");
            }
            else
            {
                inputParameters.AddParameter("@username", Username);
                ConnectionFactory.Instance()
                            .CreateConnection()
                            .ExecuteDataTableStoredProcedure(SpNames.BajaEmpresa, inputParameters);
                MessageBox.Show("Empresa modifcada correctamente!");
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
