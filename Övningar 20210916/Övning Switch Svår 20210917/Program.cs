using System;

namespace Övning_Switch_Svår_20210917
{
    enum months
    {
        Januari=1,
        Februari,
        Mars,
        April,
        Maj,
        Juni,
        Juli,
        Augusti,
        September,
        Oktober,
        November,
        December,

    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string input;
            string newInput;

            input = Console.ReadLine();
            input.ToLower();
            newInput = input.Substring(0, 1);
            newInput.ToUpper();
            newInput += input[1..];

            Enum.TryParse(typeof(months), newInput, out object obj);

            switch ((int)obj)
            {
                case (int)months.Januari:
                    break;
                default:
                    break;
            }


        }
    }
}
