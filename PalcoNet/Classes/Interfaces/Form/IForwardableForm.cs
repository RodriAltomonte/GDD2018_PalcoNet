using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Form.Interfaces
{
    [Obsolete]
    interface IForwardableForm
    {
        void ForwardTo(System.Windows.Forms.Form nextForm);
    }
}
