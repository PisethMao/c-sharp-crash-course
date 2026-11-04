namespace FirstProgram._18._Exceptions.Type___Operation;

public class NotImplemented
{
    private static void Refund()
    {
        throw new NotImplementedException("Refund is not implemented yet.");
    }

    public static void Run()
    {
        try
        {
            Refund();
        }
        catch (NotImplementedException e)
        {
            Console.WriteLine($"NotImplementedException: {e.Message}");
        }
    }
}