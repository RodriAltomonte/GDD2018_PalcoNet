using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Factory.Form
{
    static class PostLoginFormFactory
    {
        private static IDictionary<decimal, System.Windows.Forms.Form> formMap;

        static PostLoginFormFactory() 
        {
            formMap = new Dictionary<decimal, System.Windows.Forms.Form>();

        }

    }
}
