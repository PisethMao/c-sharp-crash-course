namespace FirstProgram._11._Class_Object.Constructor.overloading;

public class Program
{
    public static void Run()
    {
        var s1 = new Overloading();
        var s2 = new Overloading("Piseth");
        var s3 = new Overloading("Piseth", 21);
        Console.WriteLine(s1.Name);
        Console.WriteLine(s2.Name);
        Console.WriteLine(s3.Name);
    }
}