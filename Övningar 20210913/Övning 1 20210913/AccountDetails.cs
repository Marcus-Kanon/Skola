using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Övning_1_20210913
{

    class AccountDetails
    {
        public delegate void OnAccountCreatedEventHandler(object source, EventArgs args);
        public event OnAccountCreatedEventHandler AccountCreated;

        readonly int ACCOUNT_NUMBER = 0;
        readonly int ACCOUNT_NAME = 1;
        readonly int ACCOUNT_BALANCE = 2;
        readonly int ACCOUNT_PASSWORD = 3;
        readonly int ACCOUNT_USERNAME = 4;

        readonly int ACCOUNT_FIELDS = 5;

        public long accountNumber;
        private string accountUserName;
        private string accountPassword;
        public string accountName;
        public double accountBalance;

        public string database="accounts";
        private string salt = "Secretstuff";

        public void OnAccountError(int error)
        {
            switch (error)
            {
                case 1: Console.WriteLine("Wrong number of columns in data"); break;
                default: break;
            }
        }

        public AccountDetails()
        {
            
        }
        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        internal static string passwordEncryption(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            var sha = new SHA256Managed();

            byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] hash = sha.ComputeHash(textData);
            return BitConverter.ToString(hash).Replace("-", String.Empty);

        }

        public bool getAccountDetails(string userName, string password)
        {
            //checkFileValid()
            string filePath = /*AppDomain.CurrentDomain.BaseDirectory*/@"C:\Users\Kanon\source\repos\Skola\Övningar 20210913\Övning 1 20210913\" + database + ".txt";
            string[] fileLines = System.IO.File.ReadAllLines(filePath);
            string[] file_accountData;
            bool find = false;

            for (int i = 0; i < fileLines.Length; i++)
            {
                //checkAccountInfoValid()

                file_accountData = fileLines[i].Split(" ");

                if (file_accountData.Length != ACCOUNT_FIELDS) { OnAccountError(1); return false; }

                if (file_accountData[ACCOUNT_USERNAME]==userName && file_accountData[ACCOUNT_PASSWORD]==passwordEncryption(password))
                {
                    if( double.TryParse(file_accountData[ACCOUNT_BALANCE], out accountBalance) &&
                    long.TryParse(file_accountData[ACCOUNT_NUMBER], out accountNumber) )
                    {
                        accountName = file_accountData[ACCOUNT_NAME];
                        accountPassword = file_accountData[ACCOUNT_PASSWORD];
                        accountUserName = file_accountData[ACCOUNT_USERNAME];

                        return true;

                    }


                }
            }



            return false;
        }

        public bool updateAccountDetails()
        {
            string filePath = /*AppDomain.CurrentDomain.BaseDirectory*/@"C:\Users\Kanon\source\repos\Skola\Övningar 20210913\Övning 1 20210913\" + database + ".txt";
            string[] fileLines = System.IO.File.ReadAllLines(filePath);
            string createDB="";

            //Pass the filepath and filename to the StreamWriter Constructor
            

            string[] file_accountData;

            for (int i = 0; i < fileLines.Length; i++)
            {
                file_accountData = fileLines[i].Split(" ");

                if(file_accountData[ACCOUNT_USERNAME] == accountUserName)
                {
                    createDB += accountNumber.ToString() + " " + accountName + " " + accountBalance.ToString() + " " + accountPassword + " " + accountUserName + "\n";
                }
                else
                {
                    createDB += fileLines[i] + "\n";
                }
            }

            StreamWriter sw = new StreamWriter(@"C:\Users\Kanon\source\repos\Skola\Övningar 20210913\Övning 1 20210913\" + database + ".txt");
            sw.Write(createDB);
            sw.Close();

            return true;
        }

        public void setPassword(string text)
        {
            accountPassword = passwordEncryption(text);

        }

        protected virtual void OnAccountCreated()
        {
            if (AccountCreated != null)
                AccountCreated(this, EventArgs.Empty);
        }
    }
}
