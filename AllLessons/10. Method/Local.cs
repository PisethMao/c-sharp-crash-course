namespace FirstProgram._10._Method;

public class Local
{
    private static int Calculate(int a, int b)
    {
        return Multiply(a, b);
        int Multiply(int x, int y)
        {
            return x * y;
        }
    }
    
    public static void Run()
    {
        Console.WriteLine(Calculate(2, 3));
    }
}