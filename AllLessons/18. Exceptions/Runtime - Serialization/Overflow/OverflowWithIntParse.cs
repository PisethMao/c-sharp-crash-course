namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class OverflowWithIntParse
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            if (input is null)
            {
                Console.WriteLine("No input was provided.");
                return;
            }
            var number = int.Parse(input);
            Console.WriteLine($"Number: {number}");
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