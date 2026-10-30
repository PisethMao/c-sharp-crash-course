namespace FirstProgram._10._Method;

public class Recursive
{
    private static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    public static void Run()
    {
        var result = Factorial(5);
        Console.WriteLine($"Result: {result}");
    }
}