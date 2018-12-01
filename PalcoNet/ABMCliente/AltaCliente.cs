using Classes.DatabaseConnection;
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
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using System.Data.SqlClient;

namespace PalcoNet.ABMCliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
            //Rellenar el combo box de roles y el de tipo de documento
            List<string> tiposDocumento = new List<string>();
            tiposDocumento.Add("CI");
            tiposDocumento.Add("DNI");
            cbDocumento.DataSource = tiposDocumento;

            DataSet ds = ConnectionFactory.Instance()
                                            .CreateConnection()
                                            .ExecuteDataSetSqlQuery("SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE habilitado=1","id_Rol");
            cbRol.DisplayMember = "id_Rol";
            cbRol.DataSource = ds.Tables["id_Rol"];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsAnyFieldEmpty(this))
            {
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                Cliente nCliente = new Cliente();
                nCliente.Nombre = tbNombre.Text;
                nCliente.Apellido = tbNombre.Text;
                nCliente.Username = tbNombre.Text;
                nCliente.Password = tbPassword.Text;
                nCliente.IdRol = decimal.Parse(cbRol.SelectedText);
                nCliente.TipoDocumento = cbDocumento.SelectedText;
                nCliente.NumeroDocumento = decimal.Parse(tbNroDocumento.Text);
                nCliente.CUIL = tbCuil.Text;
                nCliente.Mail = tbEmail.Text;
                nCliente.Telefono = tbTelefono.Text;
                nCliente.DireccionCalle = tbDirCalle.Text;
                nCliente.NumeroCalle = decimal.Parse(tbNroCalle.Text);
                nCliente.Depto = tbDepartamento.Text;
                nCliente.NroPiso = decimal.Parse(tbNroPiso.Text);
                nCliente.Localidad = tbLocalidad.Text;
                nCliente.CodigoPostal = tbCodigoPostal.Text;
                nCliente.FechaDeNacimiento = dtpFechaNacimiento.Value;
                nCliente.FechaDeCreacion = dtpFechaCreacion.Value;
                nCliente.Telefono = dtpTelefono.Text;
                nCliente.Tarjeta = tbTarjeta.Text;

                inputParameters.AddParameter("@username", nCliente.Username);
                inputParameters.AddParameter("@password", nCliente.Password);
                inputParameters.AddParameter("@rol", nCliente.IdRol);
                inputParameters.AddParameter("@nombre", nCliente.Nombre);
                inputParameters.AddParameter("@apellido", nCliente.Apellido);
                inputParameters.AddParameter("@tipo_documento", nCliente.TipoDocumento);
                inputParameters.AddParameter("@nro_documento", nCliente.NumeroDocumento);
                inputParameters.AddParameter("@cuil", nCliente.CUIL);
                inputParameters.AddParameter("@mail", nCliente.Mail);
                inputParameters.AddParameter("@telefono", nCliente.Telefono);
                inputParameters.AddParameter("@direccion_calle", nCliente.DireccionCalle);
                inputParameters.AddParameter("@numero_calle", nCliente.NumeroCalle);
                inputParameters.AddParameter("@numero_piso", nCliente.NroPiso);
                inputParameters.AddParameter("@departamento", nCliente.Depto);
                inputParameters.AddParameter("@localidad", nCliente.Localidad);
                inputParameters.AddParameter("@codigo_postal", nCliente.CodigoPostal);
                inputParameters.AddParameter("@fecha_de_nacimiento", nCliente.FechaDeNacimiento);
                inputParameters.AddParameter("@fecha_de_creacion", nCliente.FechaDeCreacion);
                inputParameters.AddParameter("@tarjeta", nCliente.Tarjeta);
                try
                {
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.AltaCliente, inputParameters);
                }
                catch (SqlException sqle) { MessageBox.Show(sqle.Message); }
            }
            else { MessageBox.Show("Por favor rellena todos los campos"); }
        }

     

        
       
        

    }
}
