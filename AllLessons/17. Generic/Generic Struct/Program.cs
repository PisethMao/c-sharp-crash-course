namespace FirstProgram._17._Generic.Generic_Struct;

public class Program
{
    public static void Run()
    {
        var student = new Pair<int, string>(1, "Piseth");
        Console.WriteLine(student.First);
        Console.WriteLine(student.Second);
        var coordinates = new Pair<double, double>(1.5, 2.3);
        Console.WriteLine(coordinates.First);
        Console.WriteLine(coordinates.Second);
    }
}