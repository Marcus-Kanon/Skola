using System;

enum whatTodo
{
    square=1,
    devideBy2=2

}

namespace Föreläsning_2_20210916
{
    delegate void myDelegate(int param1);

    class Program
    {



        static void Main(string[] args)
        {

            int num = 1;
            myDelegate myAction = num switch
            {
                (int)whatTodo.square => (a) => { Console.WriteLine("Case 1! a*a=" + a*a); },
                (int)whatTodo.devideBy2 => (a) => { Console.WriteLine("Case 2! a/2=" + a); },
                _ => (a) => {  }

            };

            myAction(5);
        }
    }
}
