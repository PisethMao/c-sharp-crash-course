namespace FirstProgram._10._Method;

public class Overloaded
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
        Console.WriteLine(Add(10.5, 20.55));
    }
}