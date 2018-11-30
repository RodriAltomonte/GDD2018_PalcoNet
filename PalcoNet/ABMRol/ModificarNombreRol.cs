using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
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
    public partial class ModificarNombreRol : Form
    {
        public ModificarNombreRol()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //CHEQUEAR QUE LOS CAMPOS NO ESTEN VACIOS
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            
            inputParameters.AddParameter("@nombreRolAntiguo",txtNombreAntiguo.Text);
            inputParameters.AddParameter("@nombreRolNuevo",txtNombreNuevo.Text);
            try
            {
                ConnectionFactory.Instance().CreateConnection()
                                            .ExecuteDataTableStoredProcedure(SpNames.ModificarRol, inputParameters);
                MessageBox.Show(this, "Rol modificado correctamente!");
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show(sqlE.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
