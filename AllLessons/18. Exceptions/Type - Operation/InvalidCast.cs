namespace FirstProgram._18._Exceptions.Type___Operation;

public class InvalidCast
{
    public static void Run()
    {
        try
        {
            object value = "123";
            var number = (int)value;
            Console.WriteLine(number);
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine($"InvalidCastException: {e.Message}");
        }
    }
}