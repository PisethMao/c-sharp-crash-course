namespace FirstProgram._10._Method;

public class Static
{
    private static int Multiply(int x, int y)
    {
        return x * y;
    }
    
    public static void Run()
    {
        var result = Multiply(10, 20);
        Console.WriteLine(result);
    }
}