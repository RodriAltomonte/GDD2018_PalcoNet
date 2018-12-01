using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
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
using PalcoNet.Classes.Model;
using TFUtilites;

namespace PalcoNet.ABMRol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            
            DataTable dt = new DataTable();
            dt = ConnectionFactory.Instance().CreateConnection()
                    .ExecuteDataTableSqlQuery("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad");
            dgvFuncionalidades.DataSource = dt;
        }

        private void AltaRol_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!TextFieldUtils.IsAnyFieldEmpty(this))
            {
            StoredProcedureParameterMap RolParameters = new StoredProcedureParameterMap();
            StoredProcedureParameterMap FuncionalidadParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dgvFuncionalidades.SelectedCells;
            
            Rol nRol = new Rol();
            nRol.Descripcion = txtRolNombre.Text;
            nRol.IdRol = decimal.Parse(txtIdRol.Text);
            nRol.Habilitado = chbxHabilitado.Checked;

           Funcionalidad nFuncionalidad = new Funcionalidad();

           RolParameters.AddParameter("@nombreRol",nRol.Descripcion);
           RolParameters.AddParameter("@habilitado",nRol.Habilitado);
           RolParameters.AddParameter("@id_rol", nRol.IdRol);
           try
           {
            ConnectionFactory.Instance()
                             .CreateConnection()
                             .ExecuteDataTableStoredProcedure(SpNames.AltaRol,RolParameters);
               
               //AGREGO LAS FUNCIONALIDADES AL ROL
               
            foreach (DataGridViewCell selected in cells)
            {
                nFuncionalidad.Id = decimal.Parse(selected.Value.ToString());
                FuncionalidadParameters.AddParameter("@rolNombre",nRol.Descripcion);
                FuncionalidadParameters.AddParameter("@funcionalidadRol",nFuncionalidad.Id);
                ConnectionFactory.Instance()
                                 .CreateConnection()
                                 .ExecuteDataTableStoredProcedure(SpNames.AgregarFuncionalidadRol, FuncionalidadParameters);

                FuncionalidadParameters.RemoveParameters();
                
            }
            MessageBox.Show(this, "Rol dado de alta correctamente!");

           }catch(SqlException ex)
           {
               MessageBox.Show(ex.Message);
           }
            }else
            {
                MessageBox.Show("Por favor rellena todos los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
