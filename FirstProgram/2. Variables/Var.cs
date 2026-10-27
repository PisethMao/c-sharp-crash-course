namespace FirstProgram._2._Variables;

public class Var
{
    public static void Run()
    {
        var name = "John";
        var age = 25;
        // age = 30; // Can Use
        // age = "abc"; // Cannot Use
        var height = 1.75m;
        var isStudent = true;
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Is Student: {isStudent}");
    }
}