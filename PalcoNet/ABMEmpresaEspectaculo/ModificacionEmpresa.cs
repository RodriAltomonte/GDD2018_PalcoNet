using Classes.DatabaseConnection;
using Classes.Util;
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
            RazonSocial.Text = razon_social;
            Mail.Text = mail;
            Telefono.Text = telefono;
            DirCalle.Text = calle;
            Numero.Text = nro_calle;
            Departamento.Text = depto;
            Localidad.Text = localidad;
            CodPostal.Text = codigo_postal;
            Ciudad.Text = ciudad;
            StringUtil.ParseCuil(Verificador1, NroCUIT, DigitoVerificador, ciut);
            cbxHabilitado.Checked = habilitada;

            CallerForm = callerForm;
            
        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsValidNumericField(Verificador1, NroCUIT, DigitoVerificador, Numero, Telefono)
                || !TextFieldUtils.IsValidTextField(Ciudad, RazonSocial, Localidad))
            {
               
            }
            else
            {
                var cuit = Verificador1.Text + NroCUIT.Text + DigitoVerificador.Text;
                if (!TextFieldUtils.IsAnyFieldEmpty(this))
                {
                    
                    if (TextFieldUtils.CUIT.EsCuitValido(cuit))
                    {
                        StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                        inputParameters.AddParameter("@cuitOriginal", CUIT);
                        inputParameters.AddParameter("@razon_social", RazonSocial.Text);
                        inputParameters.AddParameter("@mail", Mail.Text);
                        inputParameters.AddParameter("@telefono", decimal.Parse(Telefono.Text));
                        inputParameters.AddParameter("@direccion_calle", DirCalle.Text);
                        inputParameters.AddParameter("@numero_calle", decimal.Parse(Numero.Text));
                        inputParameters.AddParameter("@nro_piso",decimal.Parse(Piso.Text));
                         inputParameters.AddParameter("@depto", Departamento.Text);
                        inputParameters.AddParameter("@localidad", Localidad.Text);
                        inputParameters.AddParameter("@cod_postal", CodPostal.Text);
                        inputParameters.AddParameter("@ciudad", Ciudad.Text);
                        inputParameters.AddParameter("@cuit", StringUtil.FormatCuil(cuit));
                        try
                        {
                            ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableStoredProcedure(SpNames.ModificarEmpresa, inputParameters);
                            MessageBox.Show("La empresa fue modificada correctamente!");
                        }
                        catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
                    }
                    else { MessageBox.Show("Revisa el cuit"); }
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
