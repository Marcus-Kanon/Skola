namespace Föreläsning_2_20210920
{
    internal class ClassLifetime
    {
        int value = 0;

        public int Value
        {
            get { return value; }
            set
            {
                if (value > 50) this.value = 50;
                if (value < 0) this.value = 0;
            }
        }
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }

        public ClassLifetime()
        {

        }

        ~ClassLifetime()
        {
            System.Console.WriteLine("NU dog den.");
        }
    }
}