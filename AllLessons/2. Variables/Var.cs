namespace FirstProgram._2._Variables;

public class Var
{
    public static void Run()
    {
        const string name = "John";
        const int age = 25;
        // age = 30; // Can Use
        // age = "abc"; // Cannot Use
        const decimal height = 1.75m;
        const bool isStudent = true;
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Is Student: {isStudent}");
    }
}