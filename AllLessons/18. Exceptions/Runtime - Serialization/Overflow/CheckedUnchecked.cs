namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class CheckedUnchecked
{
    private static void Demonstrate(int maximum)
    {
        try
        {
            var result = checked(maximum + 1);
            Console.WriteLine($"Result: {result}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Overflow exception: {e.Message}");
        }

        var uncheckedResult = unchecked(maximum + 1);
        Console.WriteLine($"Result: {uncheckedResult}");
    }

    public static void Run()
    {
        Demonstrate(int.MaxValue);
    }
}