namespace FirstProgram._18._Exceptions.Argument___Validation;

public class ArgumentNullException
{
    private static void PrintName(string? name)
    {
        System.ArgumentNullException.ThrowIfNull(name);
        Console.WriteLine(name);
    }

    public static void Run()
    {
        try
        {
            PrintName(null);
        }
        catch (System.ArgumentNullException e)
        {
            Console.WriteLine($"Argument {e.ParamName} isn't specified.");
        }
    }
}