using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PalcoNet.Classes.Util.Form;
using System.Windows.Forms;

namespace PalcoNet.Classes.Validator
{
    public class ControlValidation
    {
        private Control control;
        private string errorMessage;
        private Func<Control, bool> validation;

        public ControlValidation(Control control, Func<Control, bool> validation, string errorMessage)
        {
            this.control = control;
            this.errorMessage = errorMessage;
            this.validation = validation;
        }

        public bool Validate()
        {
            if (!validation(control))
            {
                MessageBoxUtil.ShowError(errorMessage);
                return false;
            }
            return true;
        }
    }
}
