using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        public static bool IsValidNumericField(params TextBox[] txtFields)
        {
            List<TextBox> fields = new List<TextBox>();
            fields.AddRange(txtFields);

            foreach (var f in fields.FindAll(fi => fi.Text != ""))
            {
                if (!f.Text.All(char.IsDigit))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidTextField(params TextBox[] txtFields)
        {
            string pattern = @"[\p{L} ]+$";
            Regex regex = new Regex(pattern);

            List<TextBox> fields = new List<TextBox>();
            fields.AddRange(txtFields);
            foreach (var f in fields.FindAll(fi => fi.Text != ""))
            {
                if (!regex.IsMatch(f.Text))
                {
                    return false;
                }
            }
            return true;
        }

       
        public static class CUIT
        {
            private static string _CUIT = string.Empty;
            private static bool _Valido = false;
            
        public static bool EsCuitValido(string cuit)
        {
            _CUIT = cuit;
            _Valido = false;
            return Validar();
        }
        public static bool EsCuilValido(string cuil)
        {
            _CUIT = cuil;
            _Valido = false;
            return Validar();
        }
        private static bool Validar()
        {
            if (_CUIT.Length == 0) return true;
            string CUITValidado = string.Empty;
            bool Valido = false;
            char Ch;
            for (int i = 0; i < _CUIT.Length; i++)
            {
                Ch = _CUIT[i];
                if ((Ch > 47) && (Ch < 58))
                {
                    CUITValidado = CUITValidado + Ch;
                }
            }

            _CUIT = CUITValidado;
            Valido = (_CUIT.Length == 11);
            if (Valido)
            {
                int Verificador = EncontrarVerificador(_CUIT);
                Valido = (_CUIT[10].ToString() == Verificador.ToString());
            }

            return Valido;
        }

        private static int EncontrarVerificador(string CUIT)
        {
            int Sumador = 0;
            int Producto = 0;
            int Coeficiente = 0;
            int Resta = 5;
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) Resta = 11;
                Producto = CUIT[i];
                Producto -= 48;
                Coeficiente = Resta - i;
                Producto = Producto * Coeficiente;
                Sumador = Sumador + Producto;
            }

            int Resultado = Sumador - (11 * (Sumador / 11));
            Resultado = 11 - Resultado;

            if (Resultado == 11) return 0;
            else return Resultado;
        }
    }	
    }
}
