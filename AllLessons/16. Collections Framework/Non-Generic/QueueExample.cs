using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic;

public class QueueExample
{
    public static void Run()
    {
        Queue queue = new();
        queue.Enqueue(1);
        queue.Enqueue(true);
        queue.Enqueue("Piseth");
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}