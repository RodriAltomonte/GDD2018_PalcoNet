using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.Util
{
    static class StringUtil
    {
        public static string FormatCuil(string txt)
        {
            if (String.Equals(txt, ""))
            {
                return "";
            }
           
            return txt.Substring(0,2)+'-'+txt.Substring(2,8)+'-'+txt.Substring(10,1);
        }
        public static void ParseCuil(TextBox text1, TextBox text2, TextBox text3,string cuil)
        {
            if (cuil == null || cuil.Equals(""))
            { 
                return;
            }
            else
            {
                text1.Text = cuil.Substring(0, 2);
                text2.Text = cuil.Substring(3, 8);
                text3.Text = cuil.Substring(12, 1);
                return;
            }
        }
        public static string FormatClienteListado(string nombre, string apellido, string email, string dni)
        {
            
            string query = "SELECT * FROM LOS_DE_GESTION.Cliente WHERE ";
            List<string> conditions = new List<string>();

              if( !String.Equals(nombre,""))
            {
                conditions.Add("nombre like " + "'%" + nombre + "%'");
            }
            if (!String.Equals(apellido, "") )
            {
                conditions.Add(" apellido like " + "'%" + apellido + "%'");
            }
            if (!String.Equals(email, ""))
            {
                conditions.Add("  mail like " + "'%" + email + "%'");
            }   
            if (!String.Equals(dni, ""))
            {
                conditions.Add(" numero_documento like " + "'%" + dni + "%'");
                
            }
            List<string> conds = conditions.FindAll(s => s != null);
            for (int i = 0; i < conds.Count; i++ )
            {
                if (i == conds.Count - 1)
                {
                    query += conds.ToArray()[i];
                }
                else
                {
                    query += conds.ToArray()[i] + " AND ";
                }
            }
            return query;

        }

        public static string FormatEmpresaListado(string razon_social, string cuit, string email)
        {
            string query = @"SELECT razon_social,mail,telefono,calle,nro_calle,depto,localidad,codigo_postal,ciudad,cuit,username
                            FROM LOS_DE_GESTION.Empresa WHERE ";
            List<string> conditions = new List<string>();
            string and = " AND ";

            if (!String.Equals(razon_social, ""))
            {
                conditions.Add("razon_social like " + "'%" + razon_social + "%'");
            }
            if (!String.Equals(cuit, ""))
            {
                conditions.Add("cuit like" + "'%" + cuit + "%'");
            }
            if (!String.Equals(email, ""))
            {
                conditions.Add(" mail like" + "'%" + email + "%'");
            }

            List<string> conds = conditions.FindAll(s => s != null);
            for (int i = 0; i < conds.Count; i++)
            {
                if (i == conds.Count - 1)
                {
                    query += conds.ToArray()[i];
                }
                else
                {
                    query += conds.ToArray()[i] + " AND ";
                }
            }
            return query;
        }

        public static string GetStringFromArray(string[] array, string searchString) 
        {
            return array.Where(element => element.Contains(searchString)).ToArray()[0];
        }

        public static string ParseConfigurationFileLine(string line)
        {
            string[] parsedLine = line.Split('=');
            return parsedLine[1].Trim();
        }

        public static string GetConfigValue(string[] configLines, string propertyKey) 
        {
            string line = GetStringFromArray(configLines, propertyKey);
            return ParseConfigurationFileLine(line);
        }

        public static string GenerateRandomUsername(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                            .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                            .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public static string ConcatSeparatedByComma<T>(IList<T> list)
        {
            string concat = "";
            foreach (T item in list)
            {
                concat += item.ToString() + ",";
            }
            return concat.Substring(0,concat.Length-1);
        }

       
        public static class MailUtil
        {
            private static bool invalid;
            public static bool IsValidEmail(string strIn)
            {
                invalid = false;
                if (String.IsNullOrEmpty(strIn))
                {
                    MessageBox.Show("Por favor verifique el mail");
                    return false;
                }

                // Use IdnMapping class to convert Unicode domain names.
                try
                {
                    strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));
                }
                catch (RegexMatchTimeoutException)
                {
                    MessageBox.Show("Por favor verifique el mail");
                    return false;
                }

                if (invalid)
                {
                    MessageBox.Show("Por favor verifique el mail");
                    return false;
                }
                // Return true if strIn is in valid email format.
                try
                {
                    if (Regex.IsMatch(strIn,
                           @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                           @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                           RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                    {
                        return true;
                    }
                    else {
                        MessageBox.Show("Por favor verifique el mail");
                        return false;
                    }
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }
            }

            private static string DomainMapper(Match match)
            {
                // IdnMapping class with default property values.
                IdnMapping idn = new IdnMapping();

                string domainName = match.Groups[2].Value;
                try
                {
                    domainName = idn.GetAscii(domainName);
                }
                catch (ArgumentException)
                {
                    invalid = true;
                }
                return match.Groups[1].Value + domainName;
            }

        }
    }
}
