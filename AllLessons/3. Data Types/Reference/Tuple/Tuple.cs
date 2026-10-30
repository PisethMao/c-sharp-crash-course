namespace FirstProgram._3._Data_Types.Reference.Tuple;

public class Tuple
{
    public static void Run()
    {
        var person = new Tuple<string, int>("John", 30);
        var person2 = person;
        Console.WriteLine(ReferenceEquals(person, person2));
    }
}