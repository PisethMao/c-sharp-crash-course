namespace FirstProgram._3._Data_Types.Reference.Tuple;

public class Tuple
{
    public static void Run()
    {
        Tuple<string, int> person = new Tuple<string, int>("John", 30);
        Tuple<string, int> person2 = person;
        Console.WriteLine(ReferenceEquals(person, person2));
    }
}