namespace FirstProgram._16._Collections_Framework.Queue___Stack___Priority;

public class Queue
{
    public static void Run()
    {
        Queue<string> customers = new();
        customers.Enqueue("Bob");
        customers.Enqueue("Jill");
        customers.Enqueue("Jack");
        Console.WriteLine(customers.Peek());
        Console.WriteLine(customers.Dequeue());
        Console.WriteLine(customers.Dequeue());
        Console.WriteLine(customers.Count);
    }
}