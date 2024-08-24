Console.WriteLine("Main thread's ID:" + Thread.CurrentThread.ManagedThreadId);

var task1 = Task.Run(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Task 1 is finished.");
});
var task2 = Task.Run(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Task 2 is finished.");
});
Task.WaitAll(task1, task2); // đợi cho đến khi nhiệm vụ hoàn thành và mới chuyển sang dòng tiếp theo.
Console.WriteLine("After the task.");



Console.WriteLine("Program is finished.");
Console.ReadKey();

static int CalculateLength(string input)
{
    Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(2000);
    return input.Length;
}
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