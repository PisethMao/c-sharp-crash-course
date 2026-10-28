using System.ComponentModel.DataAnnotations;

namespace FirstProgram._8._Control_Flow.Jump;

public class Goto
{
    public static void Run()
    {
        // Forward Jump
        int number = 10;
        goto Display;
        Console.WriteLine("This will be skipped!");
        Display:
        Console.WriteLine($"Number is {number}");

        // Backward Jump
        int count = 1;
        Start:
        Console.WriteLine($"Number is {count}");
        count++;
        if (count <= 5)
        {
            goto Start;
        }

        // Nested Loop with goto
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (i == 3 && j == 3)
                {
                    goto EndSearch;
                }

                Console.WriteLine($"i={i}, j={j}");
            }
        }

        EndSearch:
        Console.WriteLine("Search Completed!");

        // Goto Case
        int option = 1;
        switch (option)
        {
            case 1:
                Console.WriteLine("Option 1");
                goto case 2;
            case 2:
                Console.WriteLine("Option 2");
                break;
            default:
                Console.WriteLine("Unknown option");
                break;
        }
    }
}