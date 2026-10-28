namespace FirstProgram._8._Control_Flow.Selection;

public class SwitchExpression
{
    public static void Run()
    {
        // Traditional Approach
        int code = 200;
        string status;
        switch (code)
        {
            case 200:
                status = "Success";
                break;
            case 404:
                status = "Not Found";
                break;
            default:
                status = "Unknown";
                break;
        }
        Console.WriteLine(status);
        
        // Modern Approach
        string message = code switch
        {
            200 => "Success",
            400 => "Bad Request",
            404 => "Not Fount",
            500 => "Internal Server Error",
            _ => "Unknown"
        };
        Console.WriteLine(message);
        
        // Switch Expressions with Range
        int score = 88;
        string grade = score switch
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