namespace FirstProgram._16._Collections_Framework.Specialized___Observable.Key_Collection;

public record Student(int Id, string Name);

public class KeyedCollection
{
    public static void Run()
    {
        StudentCollection student =
        [
            new Student(1001, "John Doe"),
            new Student(1002, "Piseth Mao")
        ];
        Console.WriteLine(student[1002].Name);
        Console.WriteLine(student.ElementAt(0).Name);
    }
}