using System.Collections.Concurrent;

namespace FirstProgram._16._Collections_Framework.Concurrent;

public class ConcurrentQueue
{
    public static void Run()
    {
        ConcurrentQueue<string> tasks = new();
        tasks.Enqueue("Task 1");
        tasks.Enqueue("Task 2");
        if (tasks.TryDequeue(out var result))
        {
            Console.WriteLine(result);
        }

        Console.WriteLine(tasks.Count);
    }
}