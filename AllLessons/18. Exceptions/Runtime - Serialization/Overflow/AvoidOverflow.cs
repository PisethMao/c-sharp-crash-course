namespace FirstProgram._18._Exceptions.Runtime___Serialization.Overflow;

public class AvoidOverflow
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        var number = Console.ReadLine();
        Console.WriteLine(int.TryParse(number, out var numberResult)
                ? $"Result: {numberResult}"
                : "Invalid input"
        );
    }
}