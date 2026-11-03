using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic;

public class SortedListExample
{
    public static void Run()
    {
        SortedList students = new()
        {
            { 10, "Piseth" },
            { 20, "Pisal" },
            { 30, "Phaneth" },
        };
        foreach (DictionaryEntry entry in students)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }
    }
}