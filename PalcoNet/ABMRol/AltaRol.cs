using Classes.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.ABMRol
{
    public partial class AltaRol : Form
    {
        
        public AltaRol()
        {
            InitializeComponent();
            Connection con = ConnectionFactory.Instance().CreateConnection();
            DataTable dt = new DataTable();
            dt = con.ExecuteDataTableSqlQuery("SELECT * FROM LOS_DE_GESTION.Funcionalidad");
            dgvFuncionalidades.DataSource = dt;
        }

        private void AltaRol_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"Correcto");
        }
    }
}
