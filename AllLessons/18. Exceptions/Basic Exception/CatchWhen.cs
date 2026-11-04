namespace FirstProgram._18._Exceptions.Basic_Exception;

public class CatchWhen
{
    public static void Run()
    {
        try
        {
            throw new InvalidOperationException("ACCOUNT_BLOCKED");
        }
        catch (InvalidOperationException e) when (e.Message == "ACCOUNT_BLOCKED")
        {
            Console.WriteLine("Account has been blocked.");
        }
    }
}