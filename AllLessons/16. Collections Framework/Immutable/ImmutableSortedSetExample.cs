using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableSortedSetExample
{
    public static void Run()
    {
        var numbers = ImmutableSortedSet.Create(10, 20, 30);
        var updated = numbers.Add(40);
        Console.WriteLine(string.Join(", ", updated));
    }
}