using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;

namespace PalcoNet.Classes.Factory
{
    static class QuarterFactory
    {
        public static Trimestre FirstQuarterOf(int year)
        {
            Trimestre firstQuarter = new Trimestre();
            firstQuarter.Desde = new DateTime(year, 1, 1);
            firstQuarter.Hasta = new DateTime(year, 3, 31);
            return firstQuarter;
        }

        public static Trimestre SecondQuarterOf(int year)
        {
            Trimestre secondQuarter = new Trimestre();
            secondQuarter.Desde = new DateTime(year, 4, 1);
            secondQuarter.Hasta = new DateTime(year, 6, 30);
            return secondQuarter;
        }
        public static Trimestre ThirdQuarterOf(int year)
        {
            Trimestre thirdQuarter = new Trimestre();
            thirdQuarter.Desde = new DateTime(year, 7, 1);
            thirdQuarter.Hasta = new DateTime(year, 9, 30);
            return thirdQuarter;
        }
        public static Trimestre FourthQuarterOf(int year)
        {
            Trimestre fourthQuarter = new Trimestre();
            fourthQuarter.Desde = new DateTime(year, 10, 1);
            fourthQuarter.Hasta = new DateTime(year, 12, 31);
            return fourthQuarter;
        }

    }
}
