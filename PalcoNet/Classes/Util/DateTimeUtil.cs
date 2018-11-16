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

        public static Boolean Before(DateTime expectedBefore, DateTime compareTo)
        {
            return DateTime.Compare(expectedBefore, compareTo) < 0;
        }
    }
}
