using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableListExample
{
    public static void Run()
    {
        var names = ImmutableList.Create("John", "Doe");
        var updates = names.Add("Piseth");
        var removed = names.Remove("Piseth");
        Console.WriteLine(names.Count);
        Console.WriteLine(updates.Count);
        Console.WriteLine(removed.Count);
    }
}