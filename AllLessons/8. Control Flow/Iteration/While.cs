namespace FirstProgram._8._Control_Flow.Iteration;

public class While
{
    public static void Run()
    {
        int count = 1;
        while (count <= 100)
        {
            Console.WriteLine(count);
            count++;
        }

        // int number = 10;
        // while (number < 5)
        // {
        //     Console.WriteLine(number);
        // }

        int attempts = 0;
        bool isAuthenticated = false;
        while (attempts < 3 && !isAuthenticated)
        {
            Console.Write("Enter PIN: ");
            String? pin = Console.ReadLine();
            if (pin == "1234")
            {
                isAuthenticated = true;
                Console.WriteLine("You are login successfully!");
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect PIN!");
            }
        }
        if (!isAuthenticated)
        {
            Console.WriteLine("To many attempts, please try again!");
        }
    }
}