namespace FirstProgram._3._Data_Types.Reference;

public class Class
{
    public string Name { get; set; } = "";
    public int Age { get; set; } = 0;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public static void Run()
    {
        Class person = new() { Name = "John", Age = 25 };
        person.DisplayInfo();
    }
}