namespace FirstProgram._16._Collections_Framework.Dictionary___Map;

public class SortedList
{
    public static void Run()
    {
        SortedList<int, string> students = new()
        {
            { 2, "Piseth" }, { 1, "Phaneth" }, { 3, "Pisal" }
        };
        Console.WriteLine(students[2]);
        Console.WriteLine(students.Keys[0]);
        Console.WriteLine(students.Values[0]);
        students.Remove(2);
    }
}