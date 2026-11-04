namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class IntegerUnderflow
{
    private static int Decrement(int number)
    {
        checked
        {
            return number - 1;
        }
    }

    public static void Run()
    {
        try
        {
            var number = int.MinValue;
            Console.WriteLine($"Before serialization: {number}");
            number = Decrement(number);
            Console.WriteLine($"After serialization: {number}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Overflow exception: {e.Message}");
        }
    }
}