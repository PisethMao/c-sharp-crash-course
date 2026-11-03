namespace FirstProgram._16._Collections_Framework.Collection;

public class Collection
{
    public static void Run()
    {
        // ICollection<string> names = new List<string>();
        var names = new List<string>
        {
            "John Doe",
            "John"
        };
        Console.WriteLine(names.Count);
        names.Remove("John");
        Console.WriteLine(names.Count);
    }
}