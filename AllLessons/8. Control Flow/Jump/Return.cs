namespace FirstProgram._8._Control_Flow.Jump;

public class Return
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static bool isAdult(int age)
    {
        if (age < 18)
        {
            return false;
        }
        return true;
    }

    public static void Run()
    {
        int result = Add(1, 2);
        Console.WriteLine(result);
        Console.WriteLine(isAdult(20));
    }
}