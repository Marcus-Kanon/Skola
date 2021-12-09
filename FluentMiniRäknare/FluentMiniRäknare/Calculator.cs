using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMiniRäknare
{
    public class Calculator
    {
        List<double> mem = new List<double>();
        char op;
        public Calculator Digit(double d)
        {
            mem.Add(d);
            return this;
        }
        public Calculator Operator(char ope)
        {
            op = ope;
            return this;
        }
        public Calculator Clear(char ope)
        {
            mem.Clear();
            return this;
        }
        public double Result()
        {
            switch (op)
            {
                case '+':
                    return mem.Sum();
                default:
                     return mem.Sum();
            }
        }

    }
}
