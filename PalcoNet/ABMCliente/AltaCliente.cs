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

namespace PalcoNet.ABMCliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsAnyFieldEmpty(this))
            {
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@habilitado", cbxHabilitado.Checked);
                inputParameters.AddParameter("@username", StringUtil.GenerateRandomUsername(10));
                inputParameters.AddParameter("@id_rol", 2); // 2 Rol Cliente
                inputParameters.AddParameter("@password",StringUtil.GenerateRandomPassword(10)); //Contraseña creada por defecto que luego debera ser cambiada por el usuario
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
                inputParameters.AddParameter("@fecha_de_nacimiento", dtpFechaNacimiento.Text);
                inputParameters.AddParameter("@fecha_de_creacion", dtpFechaCreacion.Text);
                inputParameters.AddParameter("@tarjeta", txtTarjeta.Text);

                try
                {
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.AltaCliente, inputParameters);
                    MessageBox.Show("Cliente agreagado exitosamente!");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Por favor completa todos los campos"); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextFieldUtils.CleanAllControls(this);
        }
    }
}
