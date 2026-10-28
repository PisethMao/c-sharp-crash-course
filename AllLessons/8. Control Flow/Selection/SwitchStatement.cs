namespace FirstProgram._8._Control_Flow.Selection;

public class SwitchStatement
{
    public static void Run()
    {
        // Traditional
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }

        // Multiple Case
        int days = 6;
        switch (day)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Weekday");
                break;
            case 6:
            case 7:
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
        
        // Switch with Return
        static string GetStatus(int code)
        {
            switch (code)
            {
                case 200:
                    return "Success";
                case 400:
                    return "Bad Request";
                case 401:
                    return "Unauthorized";
                case 403:
                    return "Forbidden";
                case 404:
                    return "Not Found";
                case 405:
                    return "Method Not Allowed";
                case 406:
                    return "Not Acceptable";
                case 500:
                    return "Internal Server Error";
                case 501:
                    return "Service Unavailable";
                case 502:
                    return "Gateway Timeout";
                default:
                    return "Unknown";
            }
        }
        Console.WriteLine(GetStatus(400));
        
        // Modern Switch with Pattern Matching
        int avg = 85;
        switch (avg)
        {
            case >= 90:
                Console.WriteLine("Grade A");
                break;
            case >= 80:
                Console.WriteLine("Grade B");
                break;
            case >= 70:
                Console.WriteLine("Grade C");
                break;
            case >= 60:
                Console.WriteLine("Grade D");
                break;
            case >= 50:
                Console.WriteLine("Grade E");
                break;
            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
        
        // Switch with when
        int amount = 1200;
        switch (amount)
        {
            case int n when n >= 1000:
                Console.WriteLine("Your amount is 1000");
                break;
            case int n when n >= 100:
                Console.WriteLine("Your amount is 100");
                break;
            default:
                Console.WriteLine("Invalid Amount");
                break;
        }
    }
}