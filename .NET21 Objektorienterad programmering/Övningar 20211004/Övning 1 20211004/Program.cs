using System;

namespace Övning_1_20211004
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance=344.24;
            double fuelPrice=17.24;
            double fuelConsumption=6.7;
            double price;

            price = distance / 100 * fuelConsumption * fuelPrice;

            Console.WriteLine("KResekonstnad: " + price + " kr");
        }
    }
}
