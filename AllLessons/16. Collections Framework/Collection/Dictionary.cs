namespace FirstProgram._16._Collections_Framework.Collection;

public class Dictionary
{
    public static void Run()
    {
        // IDictionary<int, string> students = new Dictionary<int, string>
        // {
        //     { 1, "John Doe" },
        //     { 2, "John" }
        // };
        var students = new Dictionary<int, string>
        {
            { 1, "John Doe" },
            { 2, "John" }
        };
        Console.WriteLine(students[1]);
        students[1] = "Piseth";
        students.Remove(2);
    }
}