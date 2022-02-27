
Console.WriteLine(calculator.Calc.Add(4, 4));

namespace calculator
{
    public static class Calc
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class VerifyStuff
    {
        private bool StartsWith(string phone, string start)
        {
            if (phone.Length > 0 && phone[0].ToString() == start)
                return true;

            return false;
        }
        public bool VerifyPhoneNumber(string phone)
        {
            if (StartsWith(phone, "+"))
                return true;
            else
                return false;
        }
    }
}




