using System;
using System.Collections.Generic;

namespace Övning_föreläsning_List_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Skicka mail");
            q.Enqueue("Printa ut resultat");

            Console.WriteLine("Count: " + q.Count);
            Console.WriteLine("Peek: " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

        }
    }
}
