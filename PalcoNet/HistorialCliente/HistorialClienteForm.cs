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
using PalcoNet.Classes.Util;

namespace PalcoNet.HistorialCliente
{
    public partial class HistorialClienteForm : Form
    {
        private Form previousForm;

        public HistorialClienteForm()
        {
            InitializeComponent();
           // this.previousForm = previousForm;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }
    }
}
