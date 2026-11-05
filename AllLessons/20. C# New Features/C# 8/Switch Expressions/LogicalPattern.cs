namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class LogicalPattern
{
    public static void Run()
    {
        // Console.Write("Enter your age: ");
        // if (!int.TryParse(Console.ReadLine(), out var age))
        // {
        //     Console.WriteLine("Invalid Input");
        //     return;
        // }
        //
        // var result = age switch
        // {
        //     >= 0 and < 13 => "Child",
        //     >= 13 and < 18 => "Teenager",
        //     >= 18 and < 60 => "Adult",
        //     >= 60 => "Seniority",
        //     _ => "Invalid Age"
        // };
        // Console.WriteLine($"Result is: {result}");


        // Console.Write("Enter a day: ");
        // if (!int.TryParse(Console.ReadLine(), out var day))
        // {
        //     Console.WriteLine("Invalid Input");
        //     return;
        // }
        //
        // var result = day switch
        // {
        //     1 or 2 or 3 or 4 or 5 => "Weekday",
        //     6 or 7 => "Weekend",
        //     _ => "Invalid Day"
        // };
        // Console.WriteLine($"Result is: {result}");


        // Console.Write("Enter a day: ");
        // if (!int.TryParse(Console.ReadLine(), out var number))
        // {
        //     Console.WriteLine("Invalid Input");
        //     return;
        // }
        //
        // var result = number switch
        // {
        //     not 0 => "None-Zero Number",
        //     _ => "Zero Number"
        // };
        // Console.WriteLine($"Result is: {result}");


        Console.Write("Enter a day: ");
        if (!int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        var result = number switch
        {
            not (>= 0 and <= 100) => "Outside of range",
            _ => "Inside of range"
        };
        Console.WriteLine($"Result is: {result}");
    }
}