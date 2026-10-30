namespace FirstProgram._2._Variables;

public class Explicit
{
    public static void Run()
    {
        const string name = "John";
        const int age = 25;
        const decimal height = 1.75m;
        const bool isStudent = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Is Student: {isStudent}");
    }
}