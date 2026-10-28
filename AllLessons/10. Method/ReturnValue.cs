namespace FirstProgram._10._Method;

public class ReturnValue
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public static void Run()
    {
        ReturnValue r = new ReturnValue();
        int result = r.Add(1, 2);
        Console.WriteLine(result);
    }
}