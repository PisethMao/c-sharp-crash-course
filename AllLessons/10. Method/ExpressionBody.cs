namespace FirstProgram._10._Method;

public class ExpressionBody
{
    // Traditional
    // public int Add(int a, int b)
    // {
    //     return a + b;
    // }
    
    // Modern
    public int Add(int a, int b) => a + b;
    
    public static void Run()
    {
        ExpressionBody expr = new ExpressionBody();
        Console.WriteLine(expr.Add(2, 3));
    }
}