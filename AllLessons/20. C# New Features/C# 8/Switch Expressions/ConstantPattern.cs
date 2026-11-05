namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class ConstantPattern
{
    public static void Run()
    {
        Console.Write("Enter day (1-7): ");
        if (!int.TryParse(Console.ReadLine(), out var day))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        var result = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };
        Console.WriteLine($"Result is: {result}");
    }
}