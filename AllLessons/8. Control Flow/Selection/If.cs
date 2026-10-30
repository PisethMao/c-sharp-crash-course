namespace FirstProgram._8._Control_Flow.Selection;

public class If
{
    public static void Run()
    {
        // If
        const int age = 21;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }

        // If-Else
        Console.Write("Enter password: ");
        var password = Console.ReadLine() ?? "";

        Console.WriteLine(
            password == "12345678"
                ? "Login successful!"
                : "Login failed!"
        );

        // If-Else-If
        Console.Write("Enter your score: ");

        if (!int.TryParse(Console.ReadLine(), out var score))
        {
            Console.WriteLine("Invalid score!");
            return;
        }

        switch (score)
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
        
        // Nested If
        var balance = 1000m;

        Console.Write("Is account active? (true/false): ");

        if (!bool.TryParse(Console.ReadLine(), out var isAccountActive))
        {
            Console.WriteLine("Invalid account status!");
            return;
        }

        Console.WriteLine(
            isAccountActive
                ? "Account is active!"
                : "Account is inactive!"
        );

        Console.Write("Enter withdrawal amount: ");

        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid withdrawal amount!");
            return;
        }

        if (isAccountActive && amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal Successful!");
            Console.WriteLine($"Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Withdrawal Failed!");
        }
    }
}