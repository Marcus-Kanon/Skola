using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_20211018
{
    static class DateTimeRep
    {
        public static void DateInOneWeek()
        {
            var dateTime = DateTime.Now;
            dateTime = dateTime.AddDays(7.0);
            Console.WriteLine(dateTime.ToString("dd MMMM yyyy"));
        }

        public static void HalloweenWeekday()
        {
            var dateTime = new DateTime(DateTime.Now.Year, 10, 31);
            Console.WriteLine(dateTime.DayOfWeek);
        }

        public static void ConcepcionDay(DateTime birthday)
        {
            Console.WriteLine(birthday.AddMonths(-9).ToString("dd MMMM yyyyy"));
        }

        public static void TodayInfo()
        {
            Console.WriteLine("Datum: {0}", DateTime.Now.ToString("dd MMMM yyyy"));
            Console.WriteLine("Nummer: {0}", (DateTime.Now - new DateTime(2021, 01, 01)).Days);
            Console.WriteLine("Veckodag: {0}", DateTime.Now.DayOfWeek);
            Console.WriteLine("Sommartid: {0}", DateTime.Now.IsDaylightSavingTime() ? "Ja" : "Nej");
        }

    }
}
