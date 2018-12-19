using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Validator
{
    class ControlValidator
    {
        private IList<ControlValidation> validations;

        public ControlValidator()
        {
            this.validations = new List<ControlValidation>();
        }

        public bool Validate()
        {
            foreach (ControlValidation validation in validations)
            {
                if (!validation.Validate())
                {
                    return false;
                }
            }
            return true;
        }

        public void Add(ControlValidation validation)
        {
            this.validations.Add(validation);
        }
    }
}
