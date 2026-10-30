namespace FirstProgram._3._Data_Types.Value.Record;

public record struct Person (string Name, int Age);

public class Record
{
    public static void Run()
    {
        var p = new Person("John", 30);
        var p2 = p;
        p2.Name = "Jane";
        Console.WriteLine(p.Name, p.Age);
        Console.WriteLine(p2.Name, p2.Age);
    }
}