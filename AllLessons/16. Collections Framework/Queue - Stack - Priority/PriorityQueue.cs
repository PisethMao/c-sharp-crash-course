namespace FirstProgram._16._Collections_Framework.Queue___Stack___Priority;

public class PriorityQueue
{
    public static void Run()
    {
        PriorityQueue<string, int> tasks = new();
        tasks.Enqueue("Low", 3);
        tasks.Enqueue("High", 1);
        tasks.Enqueue("Medium", 2);
        while (tasks.Count > 0)
        {
            Console.WriteLine(tasks.Dequeue());
        }
    }
}