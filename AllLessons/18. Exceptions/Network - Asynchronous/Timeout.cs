namespace FirstProgram._18._Exceptions.Network___Asynchronous;

public class Timeout
{
    private static void PerformanceOperation(bool hasTimeOut)
    {
        if (hasTimeOut)
        {
            throw new TimeoutException("Operation exceed the allowed time");
        }
    }

    public static void Run()
    {
        try
        {
            PerformanceOperation(true);
        }
        catch (TimeoutException e)
        {
            Console.WriteLine($"TimeoutException: {e.Message}");
        }
    }
}