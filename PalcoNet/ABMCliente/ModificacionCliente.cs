using Classes.DatabaseConnection;
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

namespace PalcoNet.ABMCliente
{
    public partial class ModificacionCliente : Form
    {
        private string username;
        public ModificacionCliente()
        {
            InitializeComponent();
            DataSet ds = ConnectionFactory.Instance()
                                          .CreateConnection()
                                          .ExecuteDataSetSqlQuery("SELECT username FROM LOS_DE_GESTION.Cliente", "username");
            cbUsernames.DisplayMember = "username";
            cbUsernames.DataSource = ds.Tables["username"];
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            username = cbUsernames.SelectedText; 
            NavigableFormUtil.ForwardTo(this, new frmSeleccionMod(username) );
        }
    }
}
