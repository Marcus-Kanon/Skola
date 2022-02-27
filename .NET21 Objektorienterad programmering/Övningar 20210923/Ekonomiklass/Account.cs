using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekonomiklass
{
    class Account
    {
        int IdNumber;
        int accountNumber;
        double amount=0;
        string label { set; get; } = "";
        string name = "";

        Account(string name, int IdNumber, string label)
        {
            this.name = name;
            this.IdNumber = IdNumber;
            this.label = label;

            Random rnd = new Random();
            accountNumber=rnd.Next(1000000, 9999999);
        }

    }
}
