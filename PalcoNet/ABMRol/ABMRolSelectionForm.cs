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
    public partial class ABMRolSelectionForm : Form
    {
        private Form callerForm;
        private decimal IdRol;
        private const short OPTION_MODIFICACION = 1;
        private const short OPTION_BAJA= 2;

        public ABMRolSelectionForm(decimal idRol,Form CallerForm)
        {

            InitializeComponent();
            callerForm = CallerForm;
            IdRol = idRol;

         
        }

        public ABMRolSelectionForm(decimal idRol)
        {
            InitializeComponent(); 
        }

        public ABMRolSelectionForm(Form caller)
        {
            callerForm = caller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMRol.AltaRol(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMRol.SeleccionRol(this,OPTION_MODIFICACION));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this,callerForm);
        }
      

        private void btnBaja_Click(object sender, EventArgs e)
        {

            NavigableFormUtil.ForwardTo(this, new SeleccionRol(this,OPTION_BAJA)); 
        }

    }
}
