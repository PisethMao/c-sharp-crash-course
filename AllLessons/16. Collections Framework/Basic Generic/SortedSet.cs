namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class SortedSet
{
    public static void Run()
    {
        SortedSet<int> numbers = [50, 30, 40, 20];
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine(numbers.Min);
        Console.WriteLine(numbers.Max);
        numbers.Remove(20);
    }
}