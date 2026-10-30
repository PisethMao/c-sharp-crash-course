namespace FirstProgram._3._Data_Types.Reference.Class;

public class Class
{
    private string Name { get; init; } = "";
    private int Age { get; init; }

    private void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public static void Run()
    {
        Class person = new() { Name = "John", Age = 25 };
        person.DisplayInfo();
    }
}