using System.Diagnostics;

for (int i = 0; i < 5; i++)
{
    Övning3();
}

static void Övning1a()
{
    // starta tidtagning
    Stopwatch timer = Stopwatch.StartNew();

    Random random = new Random();
    double[] array = new double[180000000];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100 + 100;
    }

    // stoppa tidtagning, skriv ut resultatet
    timer.Stop();
    Console.WriteLine("1a Elapsed time: " + timer.ElapsedMilliseconds);
}
static void Övning1b()
{
    // starta tidtagning

    Random random = new Random();
    double[] array = new double[250000000];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100 + 100;
    }

    Stopwatch timer = Stopwatch.StartNew();
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    // stoppa tidtagning, skriv ut resultatet
    timer.Stop();
    Console.WriteLine("1b Elapsed time: " + timer.ElapsedMilliseconds);
}

static void Övning2()
{
    const int count = 180000000;
    Stopwatch timer = Stopwatch.StartNew();
    List<double> list = new();
    Random random = new Random();
    for (int i = 0; i < count; i++)
    {
        list.Add(random.NextDouble() * 100 + 100);
    }
    timer.Stop();
    Console.WriteLine("2a Elapsed time: " + timer.ElapsedMilliseconds);

    timer = Stopwatch.StartNew();
    double sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum += list[i];
    }
    timer.Stop();
    Console.WriteLine("2b Elapsed time: " + timer.ElapsedMilliseconds);
}
static void Övning3()
{
    const int count = 72000;
    Stopwatch timer = Stopwatch.StartNew();
    MyLinkedList<double> list = new();
    Random random = new Random();
    for (int i = 0; i < count; i++)
    {
        list.Push(random.NextDouble() * 100 + 100);
    }
    timer.Stop();
    Console.WriteLine("3a Elapsed time: " + timer.ElapsedMilliseconds);

    timer = Stopwatch.StartNew();
    double sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum += list.Get(i);
    }
    timer.Stop();
    Console.WriteLine("3b Elapsed time: " + timer.ElapsedMilliseconds);