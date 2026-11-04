namespace FirstProgram._18._Exceptions.Basic_Exception;

public class TryCatch
{
    public static void Run()
    {
        try
        {
            var a = 10;
            var b = 0;
            var result = a / b;
            Console.WriteLine($"Result is = {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Error is = {e.Message}");
        }

        Console.WriteLine("Program Continue...");
    }
}