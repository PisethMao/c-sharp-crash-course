using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic;

public class ArrayListExample
{
    public static void Run()
    {
        ArrayList values = [100, "Hello", true];
        Console.WriteLine(values[0]);
        Console.WriteLine(values[1]);
        Console.WriteLine(values[2]);
        values.Remove("Hello");
        Console.WriteLine(values.Count);
    }
}