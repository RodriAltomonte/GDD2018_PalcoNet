using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
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
                                     .ExecuteDataTableStoredProcedure(SpNames.AltaRol, inputParameters);
                    MessageBox.Show("Rol dado de alta correctamente!");
                }
                catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Por favor rellena todos los campos"); }
        }
    }
}
