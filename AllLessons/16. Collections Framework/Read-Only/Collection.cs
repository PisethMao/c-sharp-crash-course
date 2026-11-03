using System.Collections.ObjectModel;

namespace FirstProgram._16._Collections_Framework.Read_Only;

public class Collection
{
    public static void Run()
    {
        Collection<string> names = ["John Doe", "Alice"];
        names.Insert(1, "Piseth");
        Console.WriteLine(names[0]);
        Console.WriteLine(names.Count);
        names.Remove("Alice");
    }
}