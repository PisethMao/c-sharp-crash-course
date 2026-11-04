namespace FirstProgram._18._Exceptions.Runtime___Serialization;

public class StackOverflow
{
    private static void RecursiveMethod(int count)
    {
        // if (count <= 0)
        // {
        //     return;
        // }
        // Console.WriteLine($"Recursive method: {count}");
        // RecursiveMethod(count - 1);
        while (count > 0)
        {
            Console.WriteLine($"{count} times");
            count--;
        }
    }

    public static void Run()
    {
        RecursiveMethod(5);
    }
}