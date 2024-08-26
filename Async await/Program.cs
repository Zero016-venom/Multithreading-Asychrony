/* BASIC FLOW
 * await can only be used with:
 * - tasks of any type
 * - custom awaitable types (rare)
*/
var task = RunHeavyProcess();

Console.WriteLine("Doing other work");
Console.WriteLine("Doing even more work");

Console.ReadKey();

static async Task RunHeavyProcess()
{
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}

static async Task<string> HeavyCalculation()
{
    Console.WriteLine("Starting heavy calculation");
    await Task.Delay(2000);
    return "Done!";
}