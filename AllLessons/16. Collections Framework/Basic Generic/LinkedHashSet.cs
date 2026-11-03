namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class LinkedHashSet
{
    public static void Run()
    {
        // HashSet<string> seen = [];
        // List<string> ordered = [];
        string[] names = ["John Doe", "Alice", "John Doe", "Charlie"];
        // foreach(var name in names)
        // {
        //     if (seen.Add(name))
        //     {
        //         ordered.Add(name);
        //     }
        // }
        List<string> ordered = [.. names.Distinct()];
        Console.WriteLine(string.Join(", ", ordered));
    }
}