namespace FirstProgram._8._Control_Flow.Iteration;

public class DoWhile
{
    public static void Run()
    {
        int count = 10;
        do
        {
            Console.WriteLine($"Count is = {count}");
            count++;
        } while (count <= 5);

        int choice;
        do
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");
            string? userChoice = Console.ReadLine();
            if (!int.TryParse(userChoice, out choice))
            {
                choice = -1;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Deposit is selected...");
                    break;
                case 2:
                    Console.WriteLine("Withdraw is selected...");
                    break;
                case 3:
                    Console.WriteLine("Check Balance is selected...");
                    break;
                case 4:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Please select another option");
                    break;
            }
        } while (choice != 4);
    }
}