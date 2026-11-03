using System.Collections.ObjectModel;

namespace FirstProgram._16._Collections_Framework.Read_Only;

public class ReadOnlyDictionary
{
    public static void Run()
    {
        Dictionary<int, string> students = new()
        {
            [1] = "Piseth",
            [2] = "Pisal"
        };
        ReadOnlyDictionary<int, string> readOnly = new(students);
        Console.WriteLine(readOnly[1]);
        students[1] = "Phaneth";
        Console.WriteLine(readOnly[1]);
    }
}