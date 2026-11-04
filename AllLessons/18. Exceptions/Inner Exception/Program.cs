namespace FirstProgram._18._Exceptions.Inner_Exception;

public class Program
{
    public static void Run()
    {
        try
        {
            try
            {
                var number = int.Parse("abc");
                Console.WriteLine($"Number: {number}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Invalid input: {e.Message}");
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Invalid input: {e.Message}");
            Console.WriteLine($"Original Cause: {e.InnerException?.Message}");
        }
    }
}