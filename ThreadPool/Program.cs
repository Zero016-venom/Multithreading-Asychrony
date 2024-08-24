using System.Diagnostics;

const int iterations = 100;
Stopwatch stopWatch = Stopwatch.StartNew();

for(int i = 0; i<iterations; i++)
{
    ThreadPool.QueueUserWorkItem(PrintA);
}
stopWatch.Stop();
Console.WriteLine("\nTook: " + stopWatch.ElapsedMilliseconds);

Console.ReadKey();

static void PrintA(object obj)
{
    Console.Write("A");
}

static void PrintPluses(int n)
{
    Console.WriteLine("\nPrintPluses thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("+");
    }
}