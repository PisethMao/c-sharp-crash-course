namespace FirstProgram._8._Control_Flow.Jump;

public class Continue
{
    public static void Run()
    {
        for (var i = 1; i <= 5; i++)
        {
            if (i == 2)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}