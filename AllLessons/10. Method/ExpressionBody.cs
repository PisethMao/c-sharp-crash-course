namespace FirstProgram._10._Method;

public class ExpressionBody
{
    // Traditional
    // public int Add(int a, int b)
    // {
    //     return a + b;
    // }
    
    // Modern
    private static int Add(int a, int b) => a + b;
    
    public static void Run()
    {
        Console.WriteLine(Add(2, 3));
    }
}