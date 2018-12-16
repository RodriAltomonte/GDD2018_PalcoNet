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
using TFUtilites;

namespace PalcoNet.ABMRol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            try
            {
                dt = ConnectionFactory.Instance().CreateConnection()
                        .ExecuteDataTableSqlQuery("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad");
                dgvFuncionalidades.AllowUserToAddRows = false;
                dgvFuncionalidades.ReadOnly = true;
                dgvFuncionalidades.DataSource = dt;
            }
            catch (SqlQueryException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtils.IsAnyFieldEmpty(this))
            {
                Rol nRol = new Rol();
                nRol.Descripcion = tbRolNombre.Text;
                nRol.Habilitado = cbHabilitado.Checked;
                nRol.IdRol = decimal.Parse(tbIdRol.Text);
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@nombreRol", nRol.Descripcion);
                inputParameters.AddParameter("@id_rol", nRol.IdRol);
                inputParameters.AddParameter("@habilitado", nRol.Habilitado);
                try
                {
                    ConnectionFactory.Instance()
                                     .CreateConnection()
                                     .ExecuteDataTableStoredProcedure(SpNames.AltaRol,inputParameters);
                   
                    inputParameters.RemoveParameters();
                    
                    foreach (DataGridViewCell c in dgvFuncionalidades.SelectedCells)
                    {
                        inputParameters.AddParameter("@id_Rol", tbIdRol.Text);
                    
                        decimal id_funcionalidad = ConnectionFactory.Instance()
                                                                    .CreateConnection()
                                                                    .ExecuteSingleOutputSqlQuery<decimal>( @"SELECT id_Funcionalidad FROM LOS_DE_GESTION.Funcionalidad
                                                                                                           WHERE id_Funcionalidad=" + "'" + c.Value.ToString() + "'");
                        inputParameters.AddParameter("@funcionalidadRol",id_funcionalidad);
                        ConnectionFactory.Instance()
                                         .CreateConnection()
                                         .ExecuteDataTableStoredProcedure(SpNames.AgregarFuncionalidadRol, inputParameters);
                        inputParameters.RemoveParameters();
                    }
                                    
                    MessageBox.Show("Rol dado de alta correctamente!");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Por favor rellena todos los campos"); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, new ABMRol.ABMRolSelectionForm(this));
        }
    }
}
