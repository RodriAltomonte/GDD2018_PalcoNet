using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFUtilites = PalcoNet.Classes.Util.Form;

namespace TFUtilites
{
    static class TextFieldUtils
    {
        public static bool IsAnyFieldEmpty(Form myForm)
        {
            var controls = myForm.Controls.OfType<TextBox>();
            foreach (var tb in controls)
            {
                if (String.IsNullOrEmpty(tb.Text))
                {
                    return true;
                }
            }
            return false;
        }
        public static void CleanAllControls(Form myForm)
        {
            var txtControls = myForm.Controls.OfType<TextBox>();
            
            foreach (var tb in txtControls)
            {
                tb.Text = "";
            }
        }
    }
}
