using System.Collections.Specialized;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class StringCollectionExample
{
    public static void Run()
    {
        StringCollection names = ["Piseth", "Phaneth", "Pisal"];
        Console.WriteLine(names[0]);
        Console.WriteLine(names.Contains("Pisal"));
        names.Remove("Pisal");
        Console.WriteLine(names.Count);
    }
}