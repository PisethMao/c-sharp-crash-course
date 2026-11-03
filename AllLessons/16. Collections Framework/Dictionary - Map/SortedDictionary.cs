namespace FirstProgram._16._Collections_Framework.Dictionary___Map;

public class SortedDictionary
{
    public static void Run()
    {
        SortedDictionary<int, string> students = new()
        {
            { 1, "Piseth" }, { 2, "Phaneth" }, { 3, "Pisal" }
        };
        foreach (var item in students)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}