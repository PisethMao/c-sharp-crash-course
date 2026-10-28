namespace FirstProgram._8._Control_Flow.Iteration;

public class For
{
    public static void Run()
    {
        // for (int i = 1; i <= 100; i++)
        // {
        //     Console.WriteLine(i);
        // }
        //
        // for (int i = 100; i >= 1; i--)
        // {
        //     Console.WriteLine(i);
        // }

        // Multi Variable
        for (int i = 1, j = 5; i < j; i++, j--)
        {
            Console.WriteLine($"i={i}, j={j}");
        }

        // Infinite For Loop
        // for (;;)
        // {
        //     Console.WriteLine("Running");
        // }
    }
}