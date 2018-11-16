using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Util;
using PalcoNet.Classes.Util.Form;

namespace PalcoNet.GenerarPublicacion
{
    public partial class AgregarFechaHora : Form
    {
        private GenerarPublicacionForm callerForm;
        private DateTime lastDate;

        public AgregarFechaHora(GenerarPublicacionForm form, DateTime lastDate)
        {
            InitializeComponent();
            this.callerForm = form;
            this.lastDate = lastDate;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DateTimeUtil.Before(lastDate, DateTimeUtil.Of(dtpFecha.Value, dtpHora.Value)))
            {
                callerForm.AgregarItemFechaYHora(dtpFecha.Value, dtpHora.Value);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBoxUtil.ShowError("La fecha y hora deben ser posteriores a " + lastDate.ToString());
            }
        }
    }
}
