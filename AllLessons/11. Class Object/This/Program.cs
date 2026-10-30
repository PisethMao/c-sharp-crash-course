namespace FirstProgram._11._Class_Object.This;

public class Program
{
    public static void Run()
    {
        var s1 = new Students();
        var students = new Students("Piseth");
        s1.Display();
        students.Display();
    }
}