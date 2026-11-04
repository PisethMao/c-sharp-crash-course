namespace FirstProgram._18._Exceptions.Arithmetic_Exceptions;

public class DivideByZero
{
    public static void Run()
    {
        try
        {
            var a = 100;
            var b = 0;
            var result = a / b;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"DivideByZeroException: {e.Message}");
        }
    }
}