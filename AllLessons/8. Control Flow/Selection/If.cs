namespace FirstProgram._8._Control_Flow.Selection;

public class If
{
    public static void Run()
    {
        // If
        int age = 21;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }

        // If-Else
        string password = "12345678";
        if (password == "12345678")
        {
            Console.WriteLine("You are login successfully!!!");
        }
        else
        {
            Console.WriteLine("You are login failed!!!");
        }

        // If-Else-If
        int score = 85;
        if (score >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Grade D");
        }else if (score >= 50)
        {
            Console.WriteLine("Grade E");
        }else
        {
            Console.WriteLine("Grade F");
        }
        
        // Nested If
        decimal balance = 1000m;
        decimal amount = 200m;
        bool isAccountActive = true;
        if (isAccountActive)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful!");
                }
                else
                {
                    Console.WriteLine("Insufficient Funds!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Withdrawal Amount!");
            }
        }
        else
        {
            Console.WriteLine("Account Not Active!");
        }
        
        // Combine Conditions
        if (isAccountActive && amount > 0 && balance >= amount)
        {
            Console.WriteLine("Withdrawal Successful!");
        }
    }
}