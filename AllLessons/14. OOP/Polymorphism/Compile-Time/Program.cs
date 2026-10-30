namespace FirstProgram._14._OOP.Polymorphism.Compile_Time;

public class Program
{
    public static void Run()
    {
        var m1 = new OperatorOverloading(100m);
        var m2 = new OperatorOverloading(200m);

        var total = m1 + m2;

        Console.WriteLine(total.Amount);
    }
}