using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Util.Form
{
    static class MessageBoxUtil
    {
        private static readonly string ERROR = "Error";
        private static readonly string INFO = "Info";

        public static void ShowError(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, ERROR, System.Windows.Forms.MessageBoxButtons.OK);
        }

        public static void ShowInfo(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, INFO, System.Windows.Forms.MessageBoxButtons.OK);
        }

    }
}
