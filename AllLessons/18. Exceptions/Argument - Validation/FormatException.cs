namespace FirstProgram._18._Exceptions.Argument___Validation;

public class FormatException
{
    public static void Run()
    {
        try
        {
            const string input = "abcdefghijklmnop";
            var number = int.Parse(input);
            Console.WriteLine($"Number: {number}");
        }
        catch (System.FormatException e)
        {
            Console.WriteLine($"FormatException: {e.Message}");
        }
    }
}