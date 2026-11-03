namespace FirstProgram._16._Collections_Framework.Collection;

public class Set
{
    public static void Run()
    {
        // ISet<int> numbers = new HashSet<int> { 1, 2 };
        var numbers = new HashSet<int> { 1, 2 };
        Console.WriteLine(numbers.Count);
        numbers.UnionWith([3, 4]);
        Console.WriteLine(numbers.Contains(3));
    }
}