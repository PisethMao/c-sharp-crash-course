namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class HashSet
{
    public static void Run()
    {
        HashSet<int> numbers = [10, 20, 30];
        Console.WriteLine(numbers.Count);
        Console.WriteLine(numbers.Contains(10));
        numbers.Remove(10);
        numbers.UnionWith([40, 50]);
        Console.WriteLine(numbers.SetEquals([20, 30, 40, 50]));
    }
}