using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekonomiklass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Transactions.newTransaction(123123, 321321, 500.0);
            Transactions.newTransaction(124423, 321321, 800.0);
            Transactions.newTransaction(993123, 367771, 700.0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (var transaction in Transactions.transactions)
            //tableTransactions..Items.Add(transaction.Key[0] + " to " + transaction.Key[1] + " Amount: " + transaction.Value);
        }
    }
}
