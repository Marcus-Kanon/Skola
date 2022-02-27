using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_20211018
{
    static class ForeachRep
    {
        public static void PrintList(List<string> namesList)
        {
            foreach(var name in namesList)
            {
                Console.WriteLine(name);
            }
        }

        public static void PrintArray(string[] namesList)
        {
            foreach(var name in namesList)
            {
                Console.WriteLine(name);
            }
        }


        public static void PrintDictionary(Dictionary<string, string> aliasList)
        {

            /*Kalla på fubntionenm med:
            var alias = new Dictionary<string, string>();
            alias.Add("Bruce Wayne", "Batman");
            alias.Add("Clark Kent", "Superman");
            alias.Add("Peter Quill", "Star-Lord");
            alias.Add("Groot", "Groot");
            PrintDictionary(alias);
            */

            foreach(var name in aliasList)
            {
                Console.WriteLine(name.Value);
            }
        }

        public static void PrintQueue(Queue<string> todoList)
        {

            /* Kalla på fuktionen med: 
            var queue = new Queue<string>();
            queue.Enqueue("9:00 Kolla mailen");
            queue.Enqueue("9:30 Standup");
            queue.Enqueue("9:45 Kaffe");
            queue.Enqueue("10:00 programmering");
            queue.Enqueue("11:15 Möte med kund");
            queue.Enqueue("12:00 Lunch");
            PrintQueue(queue);
            */

            foreach(var todo in todoList)
            {
                Console.WriteLine(todo);
            }
        }

        public static void PrintStack(Stack<string> todoList)
        {
            /* Kalla på funktionen med:
            var stack=new Stack<string>();
            stack.Push("9:00 Kolla mailen");
            stack.Push("9:30 Standup");
            stack.Push("9:45 Kaffe");
            stack.Push("10:00 programmering");
            stack.Push("11:15 Möte med kund");
            stack.Push("12:00 Lunch");
            PrintStack(stack);
            */
            foreach(var todo in todoList)
            {
                Console.WriteLine(todo);
            }
            
        }

    }
}
