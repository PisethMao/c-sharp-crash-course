using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableArrayExample
{
    public static void Run()
    {
        var numbers = ImmutableArray.Create(10, 20, 30);
        var updated = numbers.Add(40);
        Console.WriteLine(numbers.Length);
        Console.WriteLine(updated.Length);
        Console.WriteLine(updated[3]);
    }
}