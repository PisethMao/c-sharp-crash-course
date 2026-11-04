namespace FirstProgram._18._Exceptions.Argument___Validation;

public class OverflowException
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Before Number: {number}");
            checked
            {
                number += 1;
            }

            Console.WriteLine($"After Number: {number}");
        }
        catch (System.OverflowException e)
        {
            Console.WriteLine($"Overflow exception: {e.Message}");
        }
    }
}