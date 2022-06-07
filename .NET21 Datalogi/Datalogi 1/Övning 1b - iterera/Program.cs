using System.Diagnostics;

for (int i = 0; i < 5; i++)
{
    Stopwatch stopwatchGenerate = Stopwatch.StartNew();
    Stopwatch stopwatch = Stopwatch.StartNew();

    var loop = new NumberLoop();

    loop.GenerateNumbers();
    Console.WriteLine(stopwatchGenerate.ElapsedMilliseconds);

    var sum = loop.SumOfArray();

    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}



class NumberLoop
{
    double[] array = new double[126000000];

    public void GenerateNumbers()
    {
        var rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 200);
        }
    }

    public double SumOfArray()
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}