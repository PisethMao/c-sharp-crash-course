namespace FirstProgram._8._Control_Flow.Iteration;

public class NestedLoop
{
    public static void Run()
    {
        for (var i = 1; i <= 10; i++)
        {
            for (var j = 1; j <= 10; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }
    }
}