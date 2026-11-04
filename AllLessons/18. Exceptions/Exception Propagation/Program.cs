namespace FirstProgram._18._Exceptions.Exception_Propagation;

public class Program
{
    private static void MethodC()
    {
        throw new InvalidOperationException("Error occured in MethodC()");
    }

    private static void MethodB()
    {
        MethodC();
    }

    private static void MethodA()
    {
        MethodB();
    }

    public static void Run()
    {
        try
        {
            MethodA();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"InvalidOperationException: {e.Message}");
            Console.WriteLine($"Stack Trace: {e.StackTrace}");
        }
    }
}