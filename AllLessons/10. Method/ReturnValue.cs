namespace FirstProgram._10._Method;

public class ReturnValue
{
    private static int Add(int a, int b)
    {
        return a + b;
    }

    public static void Run()
    {
        var result = Add(1, 2);
        Console.WriteLine(result);
    }
}