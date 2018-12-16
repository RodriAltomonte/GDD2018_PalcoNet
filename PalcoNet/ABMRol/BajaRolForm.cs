using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
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
using PalcoNet.Classes.Util.Form;

namespace PalcoNet.ABMRol
{
    public partial class BajaRolForm : Form
    {
        private decimal IdRol;
        private bool rolHabilitado;
        private Form CallerForm;

    
        public BajaRolForm(Form caller,decimal id_rol)
        {
            InitializeComponent();
            IdRol = id_rol;
            CallerForm = caller;

            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@idRol", IdRol);

            rolHabilitado = ConnectionFactory.Instance()
                           .CreateConnection()
                           .ExecuteSingleOutputStoredProcedure<bool>(SpNames.RolHabilitado, inputParameters, "@estaHabilitado");
            if (rolHabilitado)
            {
                btnHabilitar.Enabled = false;
            }
            else { btnDeshabilitar.Enabled = false; }
        }
      
        private void btnHabilitar_Click_1(object sender, EventArgs e)
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

        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
    }
}
