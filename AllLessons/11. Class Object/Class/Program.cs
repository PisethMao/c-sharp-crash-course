namespace FirstProgram._11._Class_Object.Class;

public class Program
{
    public static void Run()
    {
        var student = new Student { Name = "John", Age = 30 };
        // student.Name = "Piseth";
        // student.Age = 30;
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);
    }
}