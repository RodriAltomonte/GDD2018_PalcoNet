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
            }
            else { MessageBox.Show("Por favor rellena todos los campos"); }
        }

     

        
       
        

    }
}
