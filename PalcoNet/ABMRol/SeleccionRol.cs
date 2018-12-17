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
        private Form CallerForm;
        private decimal IdRol;
        private int Option;
       
       
        public SeleccionRol(Form caller,int option)
        {
            InitializeComponent();
            CallerForm = caller;
            Option = option;
            try
            {
                      DataSet  ds = ConnectionFactory.Instance()
                                              .CreateConnection()
                                              .ExecuteDataSetSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Rol", "nombre");
                cbRol.DisplayMember = "nombre";
                cbRol.DataSource = ds.Tables["nombre"];
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedRol = cbRol.Text;
            IdRol =ConnectionFactory.Instance().CreateConnection().ExecuteSingleOutputSqlQuery<decimal>(@"SELECT id_Rol 
                                                                                                       FROM LOS_DE_GESTION.Rol 
                                                                                                       WHERE nombre="+"'"+selectedRol+"'");
            //Si es una modificacion ir a la pantalla modificacion
            if (Option == 1)
            {
                NavigableFormUtil.ForwardTo(this, new ModificacionRol(IdRol, this));
            }
            //Si no ir a la pantalla de baja
            else
            {
                NavigableFormUtil.ForwardTo(this, new ABMRol.BajaRolForm(this, IdRol));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            DataSet ds = ConnectionFactory.Instance()
                                              .CreateConnection()
                                              .ExecuteDataSetSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Rol", "nombre");

            cbRol.DisplayMember = "nombre";
            cbRol.DataSource = ds.Tables["nombre"];
        }

        #region
        public void Refrescar()
        {

            DataSet ds = ConnectionFactory.Instance()
                                                     .CreateConnection()
                                                     .ExecuteDataSetSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Rol", "nombre");

            cbRol.DisplayMember = "nombre";
            cbRol.DataSource = ds.Tables["nombre"];
        }
        #endregion

    }
}
