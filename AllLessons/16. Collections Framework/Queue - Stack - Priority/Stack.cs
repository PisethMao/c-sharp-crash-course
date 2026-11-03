namespace FirstProgram._16._Collections_Framework.Queue___Stack___Priority;
public class Stack
{
    public static void Run()
    {
        Stack<string> pages = new();
        pages.Push("Home");
        pages.Push("Product");
        pages.Push("Checkout");
        Console.WriteLine(pages.Peek());
        Console.WriteLine(pages.Pop());
        Console.WriteLine(pages.Pop());
        Console.WriteLine(pages.Count);
    }
}