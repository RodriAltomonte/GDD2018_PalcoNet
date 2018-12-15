using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes.Util
{
    static class StringUtil
    {
        public static string FormatCuil(string txt)
        {
           
            return txt.Substring(0,2)+'-'+txt.Substring(3,7)+'-'+txt.Substring(10,1);
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
                    return false;


                // Use IdnMapping class to convert Unicode domain names.
                try
                {
                    strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }

                if (invalid)
                    return false;

                // Return true if strIn is in valid email format.
                try
                {
                    return Regex.IsMatch(strIn,
                          @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                          @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                          RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
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
