using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableDictionaryExample
{
    public static void Run()
    {
        var students = ImmutableDictionary<int, string>.Empty;
        students = students.Add(1, "John");
        students = students.Add(2, "Mary");
        students = students.SetItem(1, "Jane");
        Console.WriteLine(students[1]);
        var updated = students.Remove(2);
        Console.WriteLine(updated.Count);
    }
}