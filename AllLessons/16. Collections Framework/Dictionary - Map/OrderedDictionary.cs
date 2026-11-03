namespace FirstProgram._16._Collections_Framework.Dictionary___Map;

public class OrderedDictionary
{
    public static void Run()
    {
        OrderedDictionary<int, string> students = new()
        {
            { 20, "Ivan" }, { 30, "Petr" }, { 10, "Bob" }
        };
        students.Insert(3, 40, "Jane");
        var first = students.GetAt(0);
        Console.WriteLine(first.Key);
        Console.WriteLine(first.Value);
        foreach (var item in students)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}