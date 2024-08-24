Console.WriteLine("Main thread's ID:" + Thread.CurrentThread.ManagedThreadId);

Task<int> taskWithResult = Task.Run(() => CalculateLength("Good afternoon !"));
Console.WriteLine("Length is: "+ taskWithResult.Result);

string userInput;
do
{
    Console.WriteLine("Enter a command: ");
    userInput = Console.ReadLine();
} while (userInput  != "exit");
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