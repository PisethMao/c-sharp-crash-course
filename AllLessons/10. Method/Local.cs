namespace FirstProgram._10._Method;

public class Local
{
    public int Calculate(int a, int b)
    {
        int Multiply(int x, int y)
        {
            return x * y;
        }
        return Multiply(a, b);
    }
    
    public static void Run()
    {
        Local local = new Local();
        Console.WriteLine(local.Calculate(2, 3));
    }
}