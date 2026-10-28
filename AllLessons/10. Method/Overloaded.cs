namespace FirstProgram._10._Method;

public class Overloaded
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public static void Run()
    {
        Overloaded instance = new Overloaded();
        Console.WriteLine(instance.Add(10, 20));
        Console.WriteLine(instance.Add(10, 20, 30));
        Console.WriteLine(instance.Add(10.5, 20.55));
    }
}