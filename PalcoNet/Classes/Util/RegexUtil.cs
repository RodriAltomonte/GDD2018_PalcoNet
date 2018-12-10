using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalcoNet.Classes.Util.Form
{
    static class RegexUtil
    {
        public static Boolean LettersOnly(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        public static Boolean NumbersOnly(string input) 
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }
    }
}
