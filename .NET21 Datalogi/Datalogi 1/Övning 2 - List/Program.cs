using System.Diagnostics;

for (int i = 0; i < 5; i++)
{
    Stopwatch stopwatchGenerate = Stopwatch.StartNew();

    var loop = new NumberLoop();

    loop.GenerateNumbers();
    Console.WriteLine("Time to generate: " + stopwatchGenerate.ElapsedMilliseconds);

    Stopwatch stopwatchAdd = Stopwatch.StartNew();

    var sum = loop.SumOfArray();

    Console.WriteLine("Time to add: " + stopwatchAdd.ElapsedMilliseconds);
}



class NumberLoop
{
    List<Double> list = new List<Double>();

    public void GenerateNumbers()
    {
        var rand = new Random();

        for (int i = 0; i < 125000000; i++)
        {
            list.Add(rand.Next(100, 200));
        }
    }

    public double SumOfArray()
    {
        double sum = 0;
        foreach(var item in list)
        {
            sum += item;
        }

        return sum;
    }
}