namespace FirstProgram._4._Casting;

public class PatternMatching
{
    public static void Run()
    {
        object value = 100;
        
        if (value is int intValue)
        {
            Console.WriteLine($"Value is an integer: {intValue}");
        }
        else
        {
            Console.WriteLine("Value is not an integer.");
        }
    }
}