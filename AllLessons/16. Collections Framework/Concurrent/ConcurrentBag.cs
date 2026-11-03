using System.Collections.Concurrent;

namespace FirstProgram._16._Collections_Framework.Concurrent;

public class ConcurrentBag
{
    public static void Run()
    {
        ConcurrentBag<string> items = ["Apple", "Banana", "Lemon"];
        if (items.TryTake(out var result))
        {
            Console.WriteLine(result);
        }
        Console.WriteLine(items.Count);
    }
}