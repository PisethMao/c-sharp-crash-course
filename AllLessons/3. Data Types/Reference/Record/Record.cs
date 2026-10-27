namespace FirstProgram._3._Data_Types.Reference.Record;

public record Person (string Name, int Age);

public class Record
{
    public static void Run()
    {
        Person p = new Person("John", 30);
        Person p2 = p;
        Console.WriteLine(p);
        Console.WriteLine(p2);
        Console.WriteLine(ReferenceEquals(p, p2));
    }
}