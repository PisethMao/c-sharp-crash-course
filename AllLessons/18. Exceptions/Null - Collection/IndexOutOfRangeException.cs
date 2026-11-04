namespace FirstProgram._18._Exceptions.Null___Collection;

public class IndexOutOfRangeException
{
    public static void Run()
    {
        try
        {
            int[] numbers = [10, 20, 30];
            Console.WriteLine(numbers[7]);
        }
        catch (System.IndexOutOfRangeException e)
        {
            Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
        }
    }
}