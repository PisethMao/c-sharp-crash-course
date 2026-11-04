namespace FirstProgram._18._Exceptions.Arithmetic_Exceptions;

public class ArithmeticExceptionExample
{
    private static void Calculate(bool isCalculationFailed)
    {
        if (isCalculationFailed)
        {
            throw new ArithmeticException("Calculation could not be completed");
        }
    }

    public static void Run()
    {
        try
        {
            Calculate(true);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine($"ArithmeticException: {e.Message}");
        }
    }
}