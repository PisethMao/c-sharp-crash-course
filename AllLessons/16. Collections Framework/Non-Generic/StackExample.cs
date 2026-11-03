using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic;

public class StackExample
{
    public static void Run()
    {
        Stack stack = new();
        stack.Push(10);
        stack.Push(true);
        stack.Push("Piseth");
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}