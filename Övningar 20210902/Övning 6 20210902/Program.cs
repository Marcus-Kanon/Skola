using System;

namespace Övning_6_20210902
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken enhet har din temperatur?\n För Celius: 1\n För Fahrenheit: 2\n För Kelvin: 3");

            int val=int.Parse(Console.ReadLine());

            if (val == 1)
            {
                Console.WriteLine("Hur många grader Celcius är det?");
            } else if(val == 2)
            {
                Console.WriteLine("Hur många grader Fahrenheit är det?");
            } else if (val == 3)
            {
                Console.WriteLine("Hur många grader Kelvin är det?");
            } else
            {
                Console.WriteLine("Ogiltligt val");
            }

            double temp=Double.Parse(Console.ReadLine());

            Console.WriteLine("Vilken enhet vill du omvandla till?");

            int val2 = int.Parse(Console.ReadLine());

            double[] nyTemp = omvandlaTemperatur(temp, val);

            Console.WriteLine(nyTemp[val2-1]);
        }


        public static double[] omvandlaTemperatur(double temp, int enhet)
        {
            double[] nyTemp = new double[3];

            switch (enhet)
            {
                case 1: //Celsius
                    nyTemp[0] = temp;
                    nyTemp[1] = temp*1.8+32;
                    nyTemp[2] = temp + 273.15;
                    break;

                case 2: //Fahrenheit
                    nyTemp[0] = (temp-32)/1.8;
                    nyTemp[1] = temp;
                    nyTemp[2] = (temp + 459.67)/1.8;
                    break;

                case 3: //Kelvin
                    nyTemp[0] = temp-273.15;
                    nyTemp[1] = temp * 1.8 - 459.67;
                    nyTemp[2] = temp;
                    break;

                default:
                    break;
            }

            return nyTemp;
        }
    }
}
