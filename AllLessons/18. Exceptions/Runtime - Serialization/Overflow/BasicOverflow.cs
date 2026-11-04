namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class BasicOverflow
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine()!);
            checked
            {
                number += 1;
            }

            Console.WriteLine($"Number is {number}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Overflow exception: {e.Message}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Format exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Program finished");
        }
    }
}