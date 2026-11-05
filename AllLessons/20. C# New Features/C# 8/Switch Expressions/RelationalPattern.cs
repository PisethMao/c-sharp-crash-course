namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class RelationalPattern
{
    public static void Run()
    {
        Console.Write("Enter a score: ");
        if (!int.TryParse(Console.ReadLine(), out var score))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        var result = score switch
        {
            >= 90 => "Grade A",
            >= 80 => "Grade B",
            >= 70 => "Grade C",
            >= 60 => "Grade D",
            >= 50 => "Grade E",
            _ => "Grade F"
        };
        Console.WriteLine($"Result is: {result}");
    }
}