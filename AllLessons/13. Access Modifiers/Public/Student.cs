namespace FirstProgram._13._Access_Modifiers.Public;

public class Student
{
    private const string Name = "Piseth";

    public static void Display()
    {
        Console.WriteLine($"Name: {Name}");
    }
}