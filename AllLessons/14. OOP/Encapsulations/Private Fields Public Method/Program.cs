namespace FirstProgram._14._OOP.Encapsulations.Private_Fields_Public_Method;

public class Program
{
    public static void Run()
    {
        var student = new Student();

        student.SetName("Piseth");

        Console.WriteLine(student.GetName());
    }
}