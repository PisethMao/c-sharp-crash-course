using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableQueueExample
{
    public static void Run()
    {
        var queue = ImmutableQueue<string>.Empty;
        queue = queue.Enqueue("Piseth");
        queue = queue.Enqueue("Pish");
        Console.WriteLine(queue.Peek());
        var updated = queue.Dequeue();
        Console.WriteLine(updated.Peek());
        Console.WriteLine(queue.Peek());
    }
}