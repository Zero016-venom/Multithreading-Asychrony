Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);
var task = RunHeavyProcess();

Console.WriteLine("Doing other work");
Console.WriteLine("Doing even more work");

Console.ReadKey();

static async Task RunHeavyProcess()
{
    Console.WriteLine("RunHeavyProcess thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}

static async Task<string> HeavyCalculation()
{
    Console.WriteLine("HeavyCalculation thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("\nStarting heavy calculation");
    await Task.Delay(2000);
    return "Done!";
}