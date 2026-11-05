namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class DiscardPattern
{
    public static void Run()
    {
        Console.Write("Enter a status: ");
        if (!int.TryParse(Console.ReadLine(), out var status))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        var result = status switch
        {
            1 => "Active",
            2 => "Inactive",
            3 => "Pending",
            _ => "Unknown Status"
        };
        Console.WriteLine($"Result is: {result}");
    }
}