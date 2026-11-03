using System.Collections.Concurrent;

namespace FirstProgram._16._Collections_Framework.Concurrent;

public class BlockingCollection
{
    public static void Run()
    {
        using BlockingCollection<string> tasks = new(3);
        tasks.Add("Task A");
        tasks.Add("Task B");
        tasks.Add("Task C");
        Console.WriteLine(tasks.Take());
        Console.WriteLine(tasks.Take());
        tasks.CompleteAdding();
        Console.WriteLine(tasks.Take());
    }
}