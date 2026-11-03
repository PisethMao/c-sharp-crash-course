using System.Collections.Specialized;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class HybridDictionaryExample
{
    public static void Run()
    {
        HybridDictionary students = new()
        {
            { 1001, "Piseth" },
            { 1002, "Phaneth" },
        };
        Console.WriteLine(students[1002]);
        students[1002] = students[1001];
        Console.WriteLine(students[1002]);
        students.Remove(1002);
    }
}