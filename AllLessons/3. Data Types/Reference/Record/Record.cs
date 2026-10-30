namespace FirstProgram._3._Data_Types.Reference.Record;

public record Person (string Name, int Age);

public class Record
{
    public static void Run()
    {
        var p = new Person("John", 30);
        var p2 = p with { };
        Console.WriteLine(p == p2);
        Console.WriteLine(p.Equals(p2));
        Console.WriteLine(ReferenceEquals(p, p2));
    }
}