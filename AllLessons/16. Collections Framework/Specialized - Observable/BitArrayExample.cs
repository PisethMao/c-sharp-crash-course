using System.Collections;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class BitArrayExample
{
    public static void Run()
    {
        BitArray flags =new(4)
        {
            [0] = true,
            [1] = false,
            [2] = true,
            [3] = false
        };
        foreach (bool flag in flags)
        {
            Console.WriteLine(flag);
        }

        Console.WriteLine(flags.Count);
    }
}