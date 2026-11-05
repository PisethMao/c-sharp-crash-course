namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class VarPattern
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        var result = number switch
        {
            _ when number % 2 == 0 => $"Even = {number}",
            _ => $"Odd = {number}",
        };
        Console.WriteLine($"Result is: {result}");
    }
}