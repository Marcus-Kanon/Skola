using System.Diagnostics;

for (int j = 0; j < 5; j++)
{
    double[] array = new double[126000000];
    Stopwatch stopwatch = Stopwatch.StartNew();
    var rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 200);
    }

    Console.WriteLine(stopwatch.ElapsedMilliseconds);

}
