using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic;

public class HashTableExample
{
    public static void Run()
    {
        Hashtable students = new()
        {
            { 1001, "Piseth" },
            { 1002, "Alice" }
        };
        Console.WriteLine(students[1001]);
        students[1001] = "Pisal";
        Console.WriteLine(students[1001]);
        students.Remove(1002);
    }
}