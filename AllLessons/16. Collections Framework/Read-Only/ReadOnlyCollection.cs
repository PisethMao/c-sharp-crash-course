namespace FirstProgram._16._Collections_Framework.Read_Only;

public class ReadOnlyCollection
{
    public static void Run()
    {
        List<string> names = ["Piseth", "Phaneth"];
        // ReadOnlyCollection<string> readOnly = names.AsReadOnly();
        var readOnly = names.AsReadOnly();
        Console.WriteLine(readOnly[0]);
        names.Add("Pisal");
        Console.WriteLine(readOnly.Count);
    }
}