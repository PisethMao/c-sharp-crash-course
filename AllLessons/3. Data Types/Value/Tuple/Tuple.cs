namespace FirstProgram._3._Data_Types.Value.Tuple;

public class Tuple
{
    public static void Run()
    {
        (string Name, int Age) person = ("John", 30);
        var person2 = person;
        person2.Name = "Jane";
        Console.WriteLine(person.Name);
        Console.WriteLine(person2.Name);
    }
}