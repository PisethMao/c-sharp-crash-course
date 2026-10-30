namespace FirstProgram._11._Class_Object.Constructor.overloading;

public class Program
{
    public static void Run()
    {
        var s1 = new Overloading();
        var s2 = new Overloading("Piseth");
        var s3 = new Overloading("Piseth", 21);

        Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");
        Console.WriteLine($"Name: {s2.Name}, Age: {s2.Age}");
        Console.WriteLine($"Name: {s3.Name}, Age: {s3.Age}");
    }
}