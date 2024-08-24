
var cancellationTokenSource = new CancellationTokenSource();

var task = Task.Run(() => NeverendingMethod(cancellationTokenSource),
   cancellationTokenSource.Token);

string userInput;
do
{
    userInput = Console.ReadLine();
} while (userInput != "cancel");
cancellationTokenSource.Cancel();

Thread.Sleep(2000);
Console.WriteLine("Program is finished.");
Console.ReadKey();


static void NeverendingMethod(CancellationTokenSource cancellationTokenSource)
{
    while (true)
    {
        //if (cancellationTokenSource.IsCancellationRequested)
        //{
        //    throw new OperationCanceledException(cancellationTokenSource.Token);
        //}
        cancellationTokenSource.Token.ThrowIfCancellationRequested();
        Console.WriteLine("WORKING...");
        Thread.Sleep(1500);
    }
}



