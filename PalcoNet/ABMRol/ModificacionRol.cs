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
        private Form CallerForm;
        public ModificacionRol(decimal IdRol,Form caller)
        {
            InitializeComponent();
            CallerForm = caller;
            this.IdRol = IdRol;         
        }

        private void btnModNombre_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new frmModificarNombre(IdRol));
        }

        private void btnModFuncs_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new frmModificarFuncionalidades(IdRol));
        }

      
        private void btnVolver_Click(object sender, EventArgs e)
        {
           NavigableFormUtil.BackwardTo(this, CallerForm);
        }
          
        }

      
        
    }

