using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Util
{
    static class DateTimeUtil
    {
        public static DateTime Of(DateTime date, DateTime time)
        {
            return new DateTime(date.Year, date.Month, date.Day, time.TimeOfDay.Hours, time.TimeOfDay.Minutes, 0);
        }

        public static DateTime Of(string shortDateString, string hourAndMinutes)
        {
            string fullDate = shortDateString + " " + hourAndMinutes;
            return Convert.ToDateTime(fullDate);
        }

        public static DateTime DateOnly(string shortDateString)
        {
            return Convert.ToDateTime(shortDateString);
        }

        public static DateTime DateOnly(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        public static DateTime ZeroSeconds(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.TimeOfDay.Hours, date.TimeOfDay.Minutes, 0);
        }

        public static Boolean Before(DateTime expectedBefore, DateTime compareTo)
        {
            return DateTime.Compare(expectedBefore, compareTo) < 0;
        }

        public static Boolean Before(string expectedBefore, string compareTo)
        {
            return DateTimeUtil.Before(Convert.ToDateTime(expectedBefore), Convert.ToDateTime(compareTo));
        }

    }
}
