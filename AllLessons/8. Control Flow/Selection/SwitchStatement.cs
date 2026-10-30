namespace FirstProgram._8._Control_Flow.Selection;

public class SwitchStatement
{
    public static void Run()
    {
        // Traditional
        Console.Write("Enter day number (1-7): ");

        if (!int.TryParse(Console.ReadLine(), out int day))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

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
                Console.WriteLine("Invalid day!");
                break;
        }

        // Multiple Case
        Console.Write("Enter day (1-7): ");

        if (!int.TryParse(Console.ReadLine(), out var days))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        switch (days)
        {
            case 1 or 2 or 3 or 4 or 5:
                Console.WriteLine("Weekday");
                break;

            case 6 or 7:
                Console.WriteLine("Weekend");
                break;

            default:
                Console.WriteLine("Invalid Day");
                break;
        }

        // Switch with Return
        // static string GetStatus(int code)
        // {
        //     switch (code)
        //     {
        //         case 200:
        //             return "Success";
        //         case 400:
        //             return "Bad Request";
        //         case 401:
        //             return "Unauthorized";
        //         case 403:
        //             return "Forbidden";
        //         case 404:
        //             return "Not Found";
        //         case 405:
        //             return "Method Not Allowed";
        //         case 406:
        //             return "Not Acceptable";
        //         case 500:
        //             return "Internal Server Error";
        //         case 501:
        //             return "Service Unavailable";
        //         case 502:
        //             return "Gateway Timeout";
        //         default:
        //             return "Unknown";
        //     }
        // }
        // Console.WriteLine(GetStatus(400));
        
        // Modern Switch with Pattern Matching
        Console.Write("Enter your score: ");

        if (!int.TryParse(Console.ReadLine(), out var avg))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

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
                Console.WriteLine("Grade F");
                break;
        }
        
        // Switch with when
        Console.Write("Enter amount: ");

        if (!int.TryParse(Console.ReadLine(), out var amount))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        switch (amount)
        {
            case >= 1000:
                Console.WriteLine("Amount is at least 1000");
                break;

            case >= 100:
                Console.WriteLine("Amount is at least 100");
                break;

            default:
                Console.WriteLine("Amount is below 100");
                break;
        }
        
        Console.WriteLine(GetStatus(400));

        return;

        static string GetStatus(int code)
        {
            return code switch
            {
                200 => "Success",
                400 => "Bad Request",
                401 => "Unauthorized",
                403 => "Forbidden",
                404 => "Not Found",
                405 => "Method Not Allowed",
                406 => "Not Acceptable",
                500 => "Internal Server Error",
                501 => "Not Implemented",
                502 => "Bad Gateway",
                503 => "Service Unavailable",
                504 => "Gateway Timeout",
                _ => "Unknown"
            };
        }
    }
}