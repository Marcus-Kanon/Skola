using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekonomiklass
{
    static class Transactions
    {
        public static Dictionary<int[], double> transactions=new Dictionary<int[], double>();

        static public void newTransaction(int DAcc, int CAcc, double amount)
        {
            int[] accounts = new int[2];
            accounts[0] = DAcc;
            accounts[1] = CAcc;

            transactions.Add(accounts, amount);
        }
    }

}
