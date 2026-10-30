namespace FirstProgram._14._OOP.Polymorphism.Compile_Time;

public class MethodOverloading
{
    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    private static double Add(double a, double b)
    {
        return a + b;
    }

    public static void Run()
    {
        Console.WriteLine(Add(10, 20));
        Console.WriteLine(Add(10, 20, 30));
        Console.WriteLine(Add(10.7, 20.6));
    }
}