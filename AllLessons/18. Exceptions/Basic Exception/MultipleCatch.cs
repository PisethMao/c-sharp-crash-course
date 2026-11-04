namespace FirstProgram._18._Exceptions.Basic_Exception;

public class MultipleCatch
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            var number = int.Parse(input!);
            var result = 100 / number;
            Console.WriteLine($"Result is = {result}");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"Null exception thrown: {e.Message}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Format exception thrown: {e.Message}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"DivideByZero exception thrown: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}