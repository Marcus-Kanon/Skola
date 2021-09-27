using System;

namespace Föreläsning_2_20210920
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLifetime cl = new ClassLifetime();

            cl.Value=60;

            Console.WriteLine(cl.getValue());


        }
    }
}
