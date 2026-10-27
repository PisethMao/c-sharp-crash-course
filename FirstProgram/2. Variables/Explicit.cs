namespace FirstProgram._2._Variables;

public class Explicit
{
    public static void Run()
    {
        string name = "John";
        int age = 25;
        decimal height = 1.75m;
        bool isStudent = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Is Student: {isStudent}");
    }
}