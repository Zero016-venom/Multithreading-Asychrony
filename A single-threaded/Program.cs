Console.WriteLine("Cores count: "+Environment.ProcessorCount);
Console.WriteLine("Main thread's ID:"+ Thread.CurrentThread.ManagedThreadId);

Thread thread1 = new Thread(() => PrintPluses(30));
Thread thread2 = new Thread(() => PrintMinuses(30));

thread1.Start();
thread2.Start();

Console.ReadKey();  

static void PrintPluses(int n)
{
    Console.WriteLine("\nPrintPluses thread's ID:" + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("+");
    }
}
static void PrintMinuses(int n)
{
    Console.WriteLine("\nPrintMinuses thread's ID:" + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("-");
    }
}