
class Program
{
    static async Task Main(string[] args)
    {
        var result = await Exercise.FormatSquaredNumbersFrom1To(10);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}

public class Exercise
{
    public static Task<string> FormatSquaredNumbersFrom1To(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("N cannot be smaller than 0.");
        }

        return Task.Run(() => GenerateSquaredFrom1To(n))
           .ContinueWith(taskOfGeneratingNumbers =>
            Format(taskOfGeneratingNumbers.Result));
    }

    private static IEnumerable<int> GenerateSquaredFrom1To(int n)
    {
        return Enumerable.Range(1, n).Select(number => number * number);
    }

    private static string Format(IEnumerable<int> numbers)
    {
        return string.Join(", ", numbers);
    }
}