using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableHashSetExample
{
    public static void Run()
    {
        var numbers = ImmutableHashSet.Create(10, 20, 30);
        var updated = numbers.Add(40);
        updated = updated.Add(20);
        updated = updated.Remove(30);
        Console.WriteLine(numbers.Count);
        Console.WriteLine(updated.Count);
    }
}