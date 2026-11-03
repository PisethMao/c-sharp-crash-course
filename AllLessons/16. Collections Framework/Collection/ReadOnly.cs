namespace FirstProgram._16._Collections_Framework.Collection;

public class ReadOnly
{
    public static void Run()
    {
        // IReadOnlyCollection<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> numbers = [1, 2, 3];
        Console.WriteLine(numbers.Count);
        // IReadOnlyList<string> names = new List<string> { "John", "Jane", "Doe" };
        List<string> names = ["John", "Jane", "Doe"];
        Console.WriteLine(names[0]);
        // IReadOnlySet<int> ids = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> ids = [1, 2, 3, 4, 5];
        Console.WriteLine(ids.Contains(3));
        // IReadOnlyDictionary<int, string> students = new Dictionary<int, string>
        // {
        //     [1] = "John",
        //     [2] = "Jane",
        // };
        var students = new Dictionary<int, string> { [1] = "John", [2] = "Jane" };
        Console.WriteLine(students[1]);
    }
}