using System;
using System.Collections.Generic;

namespace Övning_föreläsning_List_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Kolla mailen");
            stack.Push("Svara på mail");
            stack.Push("Lysnna på musik");

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(stack);


        }
    }
}
