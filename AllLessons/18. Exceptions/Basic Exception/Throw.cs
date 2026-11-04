namespace FirstProgram._18._Exceptions.Basic_Exception;

public class Throw
{
    private static void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(age),
                "Age must be greater than or equal to zero.");
        }

        Console.WriteLine($"Age is {age}");
    }

    public static void Run()
    {
        try
        {
            SetAge(-10);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"ArgumentOutOfRangeException: {e.Message}");
        }
    }
}