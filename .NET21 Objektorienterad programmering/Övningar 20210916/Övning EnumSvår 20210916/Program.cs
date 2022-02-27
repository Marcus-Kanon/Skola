using System;

namespace Övning_EnumSvår_20210916
{
    enum weekdays
    {
        Måndag=1,
        Tisdag,
        Onsdag,
        Torsdag,
        Fredag,
        Lördag,
        Söndag,

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange veckodag: ");
            string day=Console.ReadLine();
            day = day.ToLower();
            string newDay = day.Substring(0, 1);
            newDay=newDay.ToUpper();
            newDay += day.Substring(1);

            Enum.TryParse(typeof(weekdays), newDay, out object obj);
            Console.WriteLine((int)obj);
            



        }
    }
}
