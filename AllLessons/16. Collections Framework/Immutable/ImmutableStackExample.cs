using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableStackExample
{
    public static void Run()
    {
        var stack = ImmutableStack<string>.Empty;
        stack = stack.Push("Piseth");
        stack = stack.Push("Pish");
        Console.WriteLine(stack.Peek());
        var updated = stack.Pop();
        Console.WriteLine(updated.Peek());
        Console.WriteLine(stack.Peek());
    }
}