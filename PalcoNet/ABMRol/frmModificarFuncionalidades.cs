using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
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
    public partial class frmModificarFuncionalidades : Form
    {
        private decimal IdRol;
        public frmModificarFuncionalidades(decimal idRol)
        {
            IdRol = idRol;
            InitializeComponent();
            DataTable dt1 = ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Funcionalidad WHERE id_Funcionalidad NOT IN (SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol=" + "'" + IdRol + "'" + ")");
            dgvFunsDisponibles.AllowUserToAddRows = false;
            dgvFunsDisponibles.ReadOnly = true;
            dgvFunsDisponibles.DataSource = dt1;

            DataTable dt2 = ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Funcionalidad WHERE id_Funcionalidad IN (SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol="+"'"+idRol+"'"+")" );
            dgvFnsRol.AllowUserToAddRows = false;
            dgvFnsRol.ReadOnly = true;
            dgvFnsRol.DataSource = dt2;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap FuncionalidadParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dgvFunsDisponibles.SelectedCells;
           

            try
            {
                foreach (DataGridViewCell cell in cells)
                {
                    decimal Id_Funcionlidad = ConnectionFactory.Instance().CreateConnection().ExecuteSingleOutputSqlQuery<decimal>("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad WHERE nombre=" + "'" + cell.Value.ToString() + "'");
                    FuncionalidadParameters.AddParameter("@id_Rol", IdRol);
                    FuncionalidadParameters.AddParameter("@funcionalidadRol", Id_Funcionlidad);
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.AgregarFuncionalidadRol, FuncionalidadParameters);
                    FuncionalidadParameters.RemoveParameters();
                }
                Refresh();
                MessageBox.Show("Funcionalidades agregadas al rol correctamente!");
            }
            catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            DataGridViewSelectedCellCollection cells = dgvFnsRol.SelectedCells;


            try
            {
                foreach (DataGridViewCell cell in cells)
                {
                    decimal id_funcionalidad = ConnectionFactory.Instance().CreateConnection().ExecuteSingleOutputSqlQuery<decimal>("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad WHERE nombre=" + "'" + cell.Value.ToString() + "'");
                    inputParameters.AddParameter("@id_rol", IdRol);
                    inputParameters.AddParameter("@funcionalidad", id_funcionalidad);
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BorrarFuncionalidad, inputParameters);
                    inputParameters.RemoveParameters();
                }
                Refresh();
                MessageBox.Show("Funcionalidades eliminadas del rol correctamente!");
            }
            catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, new ModificacionRol(IdRol,this));
        }
        #region Auxilliary Methods
        private void Refresh()
        {
            DataTable dt1 = ConnectionFactory.Instance()
                                          .CreateConnection()
                                          .ExecuteDataTableSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Funcionalidad WHERE id_Funcionalidad NOT IN (SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol=" + "'" + IdRol + "'" + ")");
            dgvFunsDisponibles.AllowUserToAddRows = false;
            dgvFunsDisponibles.ReadOnly = true;
            dgvFunsDisponibles.DataSource = dt1;

            DataTable dt2 = ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableSqlQuery("SELECT nombre FROM LOS_DE_GESTION.Funcionalidad WHERE id_Funcionalidad IN (SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol=" + "'" + IdRol + "'" + ")");
            dgvFnsRol.AllowUserToAddRows = false;
            dgvFnsRol.ReadOnly = true;
            dgvFnsRol.DataSource = dt2;
        }
        #endregion
    }
}
