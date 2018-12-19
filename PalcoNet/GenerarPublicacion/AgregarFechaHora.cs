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
using Classes.Configuration;

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
            if (this.ValidateDates())
            {
                callerForm.AgregarItemFechaYHora(DateTimeUtil.Of(dtpFecha.Value, dtpHora.Value));
                this.Close();
                this.Dispose();
            }
        }

        private bool ValidateDates()
        {
            if (DateTimeUtil.Before(ConfigurationManager.Instance().GetSystemDateTime(), DateTimeUtil.Of(dtpFecha.Value, dtpHora.Value)))
            {
                MessageBoxUtil.ShowError("La fecha y hora de espectaculo no puede ser anterior a la fecha de hoy.")
                return false;
            }

            if (!DateTimeUtil.Before(lastDate, DateTimeUtil.Of(dtpFecha.Value, dtpHora.Value)))
            {
                MessageBoxUtil.ShowError("La fecha y hora deben ser posteriores a " + lastDate.ToString("dd/MM/yyyy HH:mm"));
                return false;
            }
            return true;
        }
    }
}
