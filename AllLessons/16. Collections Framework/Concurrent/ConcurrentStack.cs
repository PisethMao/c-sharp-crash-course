using System.Collections.Concurrent;

namespace FirstProgram._16._Collections_Framework.Concurrent;

public class ConcurrentStack
{
    public static void Run()
    {
        ConcurrentStack<int> numbers = new();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        if (numbers.TryPop(out var result))
        {
            Console.WriteLine(result);
        }
        Console.WriteLine(numbers.Count);
    }
}