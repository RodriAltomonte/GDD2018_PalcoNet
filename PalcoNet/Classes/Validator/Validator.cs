using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Validator
{
    class Validator<T>
    {        
        private IList<Validation<T>> validations;

        public Validator()
        {
            this.validations = new List<Validation<T>>();
        }

        public bool Validate()
        {
            foreach (Validation<T> validation in validations)
            {
                if (!validation.Validate())
                {
                    return false;
                }
            }
            return true;
        }

        public void Add(Validation<T> validation)
        {
            this.validations.Add(validation);
        }
    
    }
}
