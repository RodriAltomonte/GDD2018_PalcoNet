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
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Session;

namespace PalcoNet.Comprar
{
    public partial class AsociarTarjeta : Form
    {
        private Form callerForm;
        private ClienteRepository clienteRepository;

        public AsociarTarjeta(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            this.clienteRepository = new ClienteRepository();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarTarjeta())
            {
                clienteRepository.AsociarTarjeta(txtNroTarjeta.Text, Session.Instance().LoggedUsername);
                MessageBoxUtil.ShowInfo("Tarjeta asociada correctamente.");
                NavigableFormUtil.BackwardTo(this, callerForm);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }

        private bool ValidarTarjeta()
        {
            if (!RegexUtil.NumbersOnly(txtNroTarjeta.Text))
            {
                MessageBoxUtil.ShowError("Número de tarjeta inválido.");
                return false;
            }
            return true;
        }
    }
}
