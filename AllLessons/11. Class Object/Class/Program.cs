namespace FirstProgram._11._Class_Object;

public class Program
{
    public static void Run()
    {
        Student student = new Student();
        student.Name = "Piseth";
        student.Age = 30;
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);
    }
}