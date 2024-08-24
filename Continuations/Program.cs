Console.WriteLine("Main thread's ID:" + Thread.CurrentThread.ManagedThreadId);

//Task taskContinuation = Task.Run(() => CalculateLength("Good afternoon"))
//    .ContinueWith(taskWithResult =>
//    Console.WriteLine("Length is " + taskWithResult.Result))
//    .ContinueWith(completedTask =>
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine("Good evening !");
//    });

var tasks = new[]
{
    Task.Run(() => CalculateLength("Good afternoon")),
    Task.Run(() => CalculateLength("Good evening")),
    Task.Run(() => CalculateLength("Good night"))
};

var continuationTask = Task.Factory.ContinueWhenAll(tasks, completedTasks => Console.WriteLine(string.Join(", ", completedTasks.Select(task => task.Result))));

string userInput;
do
{
    Console.WriteLine("Enter a command: ");
    userInput = Console.ReadLine();
} while (userInput != "exit");

Console.WriteLine("Program is finished.");
Console.ReadKey();

static int CalculateLength(string input)
{
    Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(5000);
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