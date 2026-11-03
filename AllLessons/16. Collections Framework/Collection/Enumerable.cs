using System.Collections;

namespace FirstProgram._16._Collections_Framework.Collection;

public class Enumerable
{
    public static void Run()
    {
        IEnumerable numbers = new List<int> { 10, 20, 30 };
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}