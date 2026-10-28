namespace FirstProgram._10._Method;

public class Static
{
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    
    public static void Run()
    {
        int result = Static.Multiply(10, 20);
        Console.WriteLine(result);
    }
}