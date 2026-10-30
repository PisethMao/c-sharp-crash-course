namespace FirstProgram._4._Casting;

public class Explicit
{
    public static void Run()
    {
        const double number = 99.99;
        const int result = (int)number;

        Console.WriteLine($"Result: {result}");
    }
}