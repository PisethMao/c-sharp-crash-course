namespace FirstProgram._18._Exceptions.Argument___Validation;

public class ArgumentOutOfRangeException
{
    private static void SetAge(int age)
    {
        if (age is 0 or > 100)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(age), "Age must be between 0 and 100");
        }
    }

    public static void Run()
    {
        try
        {
            SetAge(-10);
        }
        catch (System.ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"ArgumentOutOfRangeException: {e.Message}");
        }
    }
}