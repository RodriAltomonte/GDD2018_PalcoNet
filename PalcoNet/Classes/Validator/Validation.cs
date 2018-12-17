using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Util.Form;

namespace PalcoNet.Classes.Validator
{
    class Validation<T>
    {
        private T validable;
        private string errorMessage;
        private Func<T, bool> validation;

        public Validation(T validable, Func<T, bool> validation, string errorMessage)
        {
            this.validable = validable;
            this.errorMessage = errorMessage;
            this.validation = validation;
        }

        public bool Validate()
        {
            if (!validation(validable))
            {
                MessageBoxUtil.ShowError(errorMessage);
                return false;
            }
            return true;
        }
    }
}
