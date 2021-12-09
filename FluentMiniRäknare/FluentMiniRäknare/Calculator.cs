using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMiniRäknare
{
    public class Calculator
    {
        List<double> _mem = new List<double>();
        List<char> _op = new List<char>();

        public Calculator()
        {
            _op.Add('+');
        }
        public Calculator Digit(double d)
        {
            _mem.Add(d);

            return this;
        }
        public Calculator Operator(char op)
        {
            _op.Add(op);

            return this;
        }
        public Calculator Clear()
        {
            _mem.Clear();
            _op.Clear();
            _op.Add('+');

            return this;
        }
        public double Result()
        {
            double result = 0;
            for (int i = 0; i < _mem.Count; i++)
            {
                switch (_op[i])
                {
                    case '+':
                        result += _mem[i];
                        break;
                    case '-':
                        result -= _mem[i];
                        break;
                    case '*':
                        result *= _mem[i];
                        break;
                    case '/':
                        result /= _mem[i];
                        break;
                    default:
                        throw new Exception($"Error reading operator {_op[i]}");
                }
            }

            return result;
        }
    }
}
