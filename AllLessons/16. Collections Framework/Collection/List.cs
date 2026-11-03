namespace FirstProgram._16._Collections_Framework.Collection;

public class List
{
    public static void Run()
    {
        // IList<string> names = new List<string> { "John Doe", "Piseth" };
        var names = new List<string>
        {
            "John Doe",
            "John"
        };
        Console.WriteLine(names[0]);
        names.Insert(1, "John Doe");
        names[0] = "Piseth";
        Console.WriteLine(names[0]);
    }
}