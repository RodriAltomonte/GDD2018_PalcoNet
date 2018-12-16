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

namespace PalcoNet.ABMCliente
{
    public partial class ABMClienteSelectionForm : Form
    {
        private Form CallerForm;
        public ABMClienteSelectionForm(Form caller)
        {
            InitializeComponent();
            CallerForm = caller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMCliente.AltaCliente(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMCliente.ListadoClientes(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ABMCliente.BajaCliente(this));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, CallerForm);
        }
    }
}
