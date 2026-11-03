namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class List
{
    public static void Run()
    {
        List<string> names = ["John", "Jane", "June", "John"];
        names.Insert(0, "Jine");
        Console.WriteLine(names[0]);
        names[0] = "James";
        names.Remove("June");
        Console.WriteLine(names.Contains("Jane"));
        Console.WriteLine(names.Count);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}