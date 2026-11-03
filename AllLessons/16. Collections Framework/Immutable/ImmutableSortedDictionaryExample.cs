using System.Collections.Immutable;

namespace FirstProgram._16._Collections_Framework.Immutable;

public class ImmutableSortedDictionaryExample
{
    public static void Run()
    {
        var students = ImmutableSortedDictionary<int, string>.Empty;
        students = students.Add(2, "Piseth");
        students = students.Add(1, "Phaneth");
        students = students.Add(3, "Pisal");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} - {student.Value}");
        }
    }
}