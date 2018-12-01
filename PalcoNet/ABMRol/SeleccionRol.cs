using Classes.DatabaseConnection;
using PalcoNet.Classes.CustomException;
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

namespace PalcoNet.ABMRol
{
    public partial class SeleccionRol : Form
    {
        private decimal IdRol;
        public SeleccionRol()
        {
            InitializeComponent();
            try
            {
                DataSet ds = ConnectionFactory.Instance()
                                              .CreateConnection()
                                              .ExecuteDataSetSqlQuery("SELECT id_Rol FROM LOS_DE_GESTION.Rol", "id_Rol");
                
                cbRol.DisplayMember = "id_Rol";
                cbRol.DataSource = ds.Tables["id_Rol"];
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdRol = decimal.Parse(cbRol.Text);
            NavigableFormUtil.ForwardTo(this, new ModificacionRol(IdRol));
        }
    }
}
