using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
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
    public partial class ModificacionRol : Form
    {
        private decimal IdRol;
        private bool rolHabilitado;
        public ModificacionRol(decimal IdRol)
        {
            InitializeComponent();
            this.IdRol = IdRol;

            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@idRol", IdRol);

            rolHabilitado = ConnectionFactory.Instance()
                              .CreateConnection()
                              .ExecuteSingleOutputStoredProcedure<bool>(SpNames.RolHabilitado, inputParameters, "@estaHabilitado");

            if (rolHabilitado)
            {
                btnHabilitar.Enabled=false;
            }
            else { btnDeshabilitar.Enabled=false; }
        }

        private void btnModNombre_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new frmModificarNombre(IdRol));
        }

        private void btnModFuncs_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new frmModificarFuncionalidades(IdRol));
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;

            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@id_Rol", IdRol);
            try
            {
                ConnectionFactory.Instance()
                                 .CreateConnection()
                                 .ExecuteDataTableStoredProcedure(SpNames.HabilitarRol, inputParameters);
                MessageBox.Show("Rol habilitado correctamente!");
            }
            catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;

            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@id_Rol", IdRol);
            try
            {
                ConnectionFactory.Instance()
                                 .CreateConnection()
                                 .ExecuteDataTableStoredProcedure(SpNames.BajaRol, inputParameters);
                MessageBox.Show("Rol deshabilitado correctamente!");
            }
            catch (StoredProcedureException ex) { MessageBox.Show(ex.Message); }
        }

      
        
    }
}
