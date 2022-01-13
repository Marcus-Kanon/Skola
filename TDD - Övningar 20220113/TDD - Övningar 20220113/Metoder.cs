using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD___Övningar_20220113
{
    public static class Metoder
    {
        public static int Fibonacci(int tal)
        {
            int oldValue = 0;
            int value = 1;
            int i = 0;

            while (tal > value)
            {
                value = oldValue + value;
                oldValue = value;
                i++;
            }
            return i;
        }

        public static int Calculator(int a, int b, int c, string op1, string op2)
        {
            return 0;
        }

        public static int?[] HighAndLow(int[] numbers)
        {          
            int? low = null, high = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > high || high == null)
                    high = numbers[i];

                if(numbers[i] < low || low == null)
                    low = numbers[i];

            }

            int?[] result = new int?[2] { high, low };

            return result;
        }
    }
}
