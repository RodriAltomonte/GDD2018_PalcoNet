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
                                             .ExecuteDataTableSqlQuery("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad WHERE id_Funcionalidad NOT IN (SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol=" + "'" + IdRol + "'" + ")");
            dgvFunsDisponibles.DataSource = dt1;

            DataTable dt2 = ConnectionFactory.Instance()
                                             .CreateConnection()
                                             .ExecuteDataTableSqlQuery("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol=" + "'" + IdRol + "'" );
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
                    FuncionalidadParameters.AddParameter("@id_Rol", IdRol);
                    FuncionalidadParameters.AddParameter("@funcionalidadRol", decimal.Parse(cell.Value.ToString()));
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.AgregarFuncionalidadRol, FuncionalidadParameters);
                    FuncionalidadParameters.RemoveParameters();
                }
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
                    inputParameters.AddParameter("@id_rol", IdRol);
                    inputParameters.AddParameter("@funcionalidad", decimal.Parse(cell.Value.ToString()));
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.BorrarFuncionalidad, inputParameters);
                    inputParameters.RemoveParameters();
                }
                MessageBox.Show("Funcionalidades eliminadas del rol correctamente!");
            }
            catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, new ModificacionRol(IdRol));
        }
    }
}
