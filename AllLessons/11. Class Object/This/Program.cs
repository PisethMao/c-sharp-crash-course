namespace FirstProgram._11._Class_Object.This;

public class Program
{
    public static void Run()
    {
        Students s1 = new Students();
        Students students = new Students("Piseth");
        s1.Display();
        students.Display();
    }
}