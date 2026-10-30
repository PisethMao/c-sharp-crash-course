namespace FirstProgram._8._Control_Flow.Selection;

public class SwitchExpression
{
    public static void Run()
    {
        // Traditional Approach
        Console.Write("Enter HTTP status code: ");

        if (!int.TryParse(Console.ReadLine(), out int code))
        {
            Console.WriteLine("Invalid status code!");
            return;
        }

        var status = code switch
        {
            200 => "Success",
            400 => "Bad Request",
            404 => "Not Found",
            500 => "Internal Server Error",
            _ => "Unknown"
        };

        Console.WriteLine($"Status: {status}");
        
        // Modern Approach
        var message = code switch
        {
            200 => "Success",
            400 => "Bad Request",
            404 => "Not Fount",
            500 => "Internal Server Error",
            _ => "Unknown"
        };
        Console.WriteLine(message);
        
        // Switch Expressions with Range
        Console.Write("Enter your score: ");

        if (!int.TryParse(Console.ReadLine(), out int score))
        {
            Console.WriteLine("Invalid score!");
            return;
        }

        var grade = score switch
        {
            >= 90 => "Grade A",
            >= 80 => "Grade B",
            >= 70 => "Grade C",
            >= 60 => "Grade D",
            >= 50 => "Grade E",
            _ => "Grade F"
        };

        Console.WriteLine(grade);
    }
}