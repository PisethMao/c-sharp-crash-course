namespace FirstProgram._18._Exceptions.Custom_Exceptions;

public class Program
{
    public static void Run()
    {
        try
        {
            BankService.Withdraw(100m, 200m);
        }
        catch (InsufficientBalanceException e)
        {
            Console.WriteLine($"Insufficient balance: {e.Message}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"ArgumentOutOfRangeException: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}