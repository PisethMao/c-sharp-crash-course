namespace FirstProgram._18._Exceptions.Type___Operation;

public class InvalidOperation
{
    public static void Run()
    {
        try
        {
            var numbers = new List<int>();
            var first = numbers.First();
            Console.WriteLine(first);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"InvalidOperationException: {e.Message}");
        }
    }
}