namespace FirstProgram._17._Generic.Generic_Constraints.New;

public class Student
{
    private string Name { get; set; } = "Unknown";

    public static void Run()
    {
        var factory = new Factory<Student>();
        var student = factory.Create();
        student.Name = "John";
        Console.WriteLine(student.Name);
    }
}