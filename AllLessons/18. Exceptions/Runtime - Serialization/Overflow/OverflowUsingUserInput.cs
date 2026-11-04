namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class OverflowUsingUserInput
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter first number: ");
            var number1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter second number: ");
            var number2 = int.Parse(Console.ReadLine()!);
            var result = checked(number1 + number2);
            Console.WriteLine($"Result: {result}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Overflow exception: {e.Message}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Format exception: {e.Message}");
        }
    }
}