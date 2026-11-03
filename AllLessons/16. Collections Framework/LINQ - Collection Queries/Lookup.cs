namespace FirstProgram._16._Collections_Framework.LINQ___Collection_Queries;

public class Lookup
{
    public static void Run()
    {
        var students = new[]
        {
            new { Id = 1, FirstName = "John", LastName = "Doe" },
            new { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new { Id = 3, FirstName = "Jane", LastName = "Doe" },
        };
        // ILookup<string, string> groups = students.ToLookup(
        //     student => student.FirstName,
        //     student => student.LastName
        // );
        var groups = students.ToLookup(
            student => student.FirstName,
            student => student.LastName
        );
        foreach (var group in groups["Jane"])
        {
            Console.WriteLine(group);
        }
    }
}