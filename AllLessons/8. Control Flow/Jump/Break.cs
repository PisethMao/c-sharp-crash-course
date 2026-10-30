namespace FirstProgram._8._Control_Flow.Jump;

public class Break
{
    public static void Run()
    {
        for (var i = 1; i <= 100; i++)
        {
            if (i == 50)
            {
                break;
            }
            Console.WriteLine(i);
        }
        
        // Break in Nested Loop
        for (var i = 1; i <= 10; i++)
        {
            for (var j = 1; j <= 10; j++)
            {
                if (j == 5)
                {
                    break;
                }
                Console.WriteLine($"i = {i}, j = {j}");
            }
        }
    }
}