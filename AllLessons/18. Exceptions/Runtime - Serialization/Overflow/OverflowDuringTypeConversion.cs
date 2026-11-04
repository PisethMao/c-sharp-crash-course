namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class OverflowDuringTypeConversion
{
    private static int ConvertToInt(long number)
    {
        return checked((int)number);
    }

    public static void Run()
    {
        try
        {
            var result = ConvertToInt(5_000_000_000L);
            Console.WriteLine($"Result: {result}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Overflow exception: {e.Message}");
        }
    }
}