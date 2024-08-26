var task = Process("Hello");

string userInput;
do
{
    userInput = Console.ReadLine();
} while (userInput != "stop");

Console.WriteLine("Program is finished.");

Console.ReadKey();

static async Task Process(string input)
{
    var length = await CalculateLengthAsync(input);
    await PrintAsync(length);
    Console.WriteLine("The process is finished.");
}

static int CalculateLength(string input)
{
    Console.WriteLine("Starting the CalculateLength method");
    Thread.Sleep(2000);
    return input.Length;
}

static async Task<int> CalculateLengthAsync(string input)
{
    Console.WriteLine("Starting the CalculateLength method");
    await Task.Delay(2000);
    return input.Length;
}

static void Print(int result)
{
    Console.WriteLine("Starting the Print method");
    Thread.Sleep(2000);
    Console.WriteLine("The result is " + result);
}

static async Task PrintAsync(int result)
{
    Console.WriteLine("Starting the Print method");
    await Task.Delay(2000);
    Console.WriteLine("The result is " + result);
}