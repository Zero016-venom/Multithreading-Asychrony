Exercise.RunSimpleTask();

Console.ReadKey();

public class Exercise
{
    public static void RunSimpleTask()
    {
        Console.WriteLine("Before task starting.");

        for (int i = 0; i < 3; ++i)
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine($"Iteration number {i + 1}");
            });
            Thread.Sleep(1000);
        }
        Task.WaitAll();
        Console.WriteLine("The task has finished.");
    }
}
