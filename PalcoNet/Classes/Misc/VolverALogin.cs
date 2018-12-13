using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Interfaces;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Login;

namespace PalcoNet.Classes.Misc
{
    class VolverALogin : IAccionPostCreacionUsuario
    {
        private System.Windows.Forms.Form closeable;

        public VolverALogin(System.Windows.Forms.Form closeable)
        {
            this.closeable = closeable;
        }

        public void Do(System.Windows.Forms.Form from)
        {
            closeable.Dispose();
            closeable.Close();

            NavigableFormUtil.BackwardTo(from, new LoginForm());
        }
    }
}
