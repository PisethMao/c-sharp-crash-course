namespace FirstProgram._18._Exceptions.Argument___Validation;

public class ArgumentException
{
    private static void Register(string email)
    {
        if (!email.Contains('@'))
        {
            throw new
                System.ArgumentException("Invalid email address.", nameof(email));
        }
    }

    public static void Run()
    {
        try
        {
            Register("invalid email address");
        }
        catch (System.ArgumentException e)
        {
            Console.WriteLine($"Argument exception: {e.Message}");
        }
    }
}