namespace FirstProgram._18._Exceptions.Null___Collection;

public class ArgumentOutOfRange
{
    public static void Run()
    {
        try
        {
            var numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine(numbers[5]);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"ArgumentOutOfRangeException: {e.Message}");
        }
    }
}