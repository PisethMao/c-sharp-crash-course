namespace FirstProgram._8._Control_Flow.Jump;

public class Return
{
    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static bool IsAdult(int age)
    {
        return age >= 18;
    }

    public static void Run()
    {
        var result = Add(1, 2);
        Console.WriteLine(result);
        Console.WriteLine(IsAdult(20));
    }
}