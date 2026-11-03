using System.Collections.ObjectModel;

namespace FirstProgram._16._Collections_Framework.Read_Only;

public class ReadOnlySet
{
    public static void Run()
    {
        HashSet<int> numbers = [10, 20, 30];
        ReadOnlySet<int> readOnlySet = new(numbers);
        Console.WriteLine(readOnlySet.Contains(20));
        numbers.Add(40);
        Console.WriteLine(readOnlySet.Contains(40));
    }
}