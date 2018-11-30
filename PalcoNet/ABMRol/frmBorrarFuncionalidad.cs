using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
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
    public partial class frmBorrarFuncionalidad : Form
    {
        public frmBorrarFuncionalidad(decimal idRol)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@idRol",idRol);
            dt = ConnectionFactory.Instance()
                              .CreateConnection()
                              .ExecuteDataTableStoredProcedure(SpNames.FuncionaliadesDeUnRol, inputParameters);
                              //.ExecuteDataTableSqlQuery("SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Rol=(SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre="+"'"+RolNombre+"'"+")");
            dvgFuncionalidadesRol.DataSource = dt;
        }
    }
}
