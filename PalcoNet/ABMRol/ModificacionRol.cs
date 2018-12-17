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
        private SeleccionRol CallerForm;
        

        public ModificacionRol(decimal IdRol,SeleccionRol caller)
        {
            InitializeComponent();
            CallerForm = caller;
            this.IdRol = IdRol;         
        }

        private void btnModNombre_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new frmModificarNombre(IdRol,this));
        }

        private void btnModFuncs_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new frmModificarFuncionalidades(IdRol,this));
        }

      
        private void btnVolver_Click(object sender, EventArgs e)
        {
            CallerForm.Refrescar();
           NavigableFormUtil.BackwardTo(this, CallerForm);
        }
          
        }

      
        
    }

