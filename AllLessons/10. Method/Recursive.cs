namespace FirstProgram._10._Method;

public class Recursive
{
    public static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    public static void Run()
    {
        int result = Factorial(5);
        Console.WriteLine($"Result: {result}");
    }
}