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
            Nombre.Text = nombre;
            Apellido.Text = apellido;
            cboTipoDoc.Text = tipo_documento;
            Documento.Text = nro_documento;
            StringUtil.ParseCuil(Verificador1,DNI,DigitoVerificador,CUIL);
            Mail.Text = mail;
            Telefono.Text = telefono;
            Calle.Text = calle;
            Numero.Text = nro_calle;
            Piso.Text = nro_piso;
            Departamento.Text = depto;
            Localidad.Text = localidad;
            CodPostal.Text = codigo_postal;
            dtpFechaCreacion.Text = fecha_creacion;
            dtpFechaNacimiento.Text = fecha_nacimiento;
            Tarjeta.Text = tarjeta;
            Username = username;
            doc_original = nro_documento;
            cuil_original = CUIL;
            CallerForm = caller;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsValidNumericField(Verificador1, DNI, DigitoVerificador, Documento, Telefono, Numero, Tarjeta)
                || !TextFieldUtils.IsValidTextField(Nombre, Apellido, Localidad))
            {}

            else{ 
                var cuil = Verificador1.Text + DNI.Text + DigitoVerificador.Text;
                if (!VerificarCamposNoVacios() && StringUtil.MailUtil.IsValidEmail(Mail.Text) 
                    && TextFieldUtils.DatesAreValid(Convert.ToDateTime(dtpFechaNacimiento.Text), 
                                                    Convert.ToDateTime(dtpFechaCreacion.Text)))
                {
                    if (TextFieldUtils.CUIT.EsCuilValido(cuil) && DNI.Text == Documento.Text)
                    {
                        decimal piso;
                        StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                        inputParameters.AddParameter("@nro_documentoOriginal", decimal.Parse(doc_original));
                        inputParameters.AddParameter("@cuil_original", cuil_original);
                        inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
                        inputParameters.AddParameter("@nombre", Nombre.Text);
                        inputParameters.AddParameter("@apellido", Apellido.Text);
                        inputParameters.AddParameter("@tipo_documento", cboTipoDoc.Text);
                        inputParameters.AddParameter("@nro_documento", decimal.Parse(Documento.Text));
                        inputParameters.AddParameter("@cuil", StringUtil.FormatCuil(cuil));
                        inputParameters.AddParameter("@mail", Mail.Text);
                        inputParameters.AddParameter("@telefono", Telefono.Text);
                        inputParameters.AddParameter("@dir_calle", Calle.Text);
                        inputParameters.AddParameter("@nro_calle", decimal.Parse(Numero.Text));
                        if (Piso.Text == "")
                        {
                            inputParameters.AddParameter("@nro_piso", -1);
                        }
                        else
                        {
                            inputParameters.AddParameter("@nro_piso", decimal.Parse(Piso.Text));
                        }
                        if (Departamento.Text == "")
                        {
                            inputParameters.AddParameter("@depto", -1);
                        }
                        else
                        {
                            inputParameters.AddParameter("@depto", Departamento.Text);
                        }
                        inputParameters.AddParameter("@localidad", Localidad.Text);
                        inputParameters.AddParameter("@codigo_postal", CodPostal.Text);
                        inputParameters.AddParameter("@fecha_nacimiento", Convert.ToDateTime(dtpFechaNacimiento.Text));
                        inputParameters.AddParameter("@fecha_de_creacion", Convert.ToDateTime(dtpFechaCreacion.Text));
                        inputParameters.AddParameter("@tarjeta", Tarjeta.Text);

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
                MessageBox.Show("Cliente habilitado correctamente!");
            }
            else
            {
                inputParameters.AddParameter("@username", Username);
                ConnectionFactory.Instance()
                            .CreateConnection()
                            .ExecuteDataTableStoredProcedure(SpNames.BajaCliente, inputParameters);
                MessageBox.Show("Cliente dado de baja correctamente!");
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

        #region Auxilliary Methods

        public bool VerificarCamposNoVacios()
        {
            if (Nombre.Text == "" || Apellido.Text == "" || cboTipoDoc.Text == "" || Documento.Text == ""
                || Mail.Text == "" || Telefono.Text == "" || Calle.Text == "" || Numero.Text == "" ||
                CodPostal.Text == "" || Localidad.Text == "" || Verificador1.Text == "" || DNI.Text == ""
                || DigitoVerificador.Text == "" || Tarjeta.Text == "")
            {
                MessageBox.Show("Complete los campos necesarios");
                return true;
            }
            return false;
        }


        #endregion

    }
}
