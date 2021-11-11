using System;
using System.Collections.Generic;

namespace Övningar_20211018
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<string>();
            stack.Push("9:00 Kolla mailen");
            stack.Push("9:30 Standup");
            stack.Push("9:45 Kaffe");
            stack.Push("10:00 programmering");
            stack.Push("11:15 Möte med kund");
            stack.Push("12:00 Lunch");
            ForeachRep.PrintStack(stack);
        }

        

    }
}
