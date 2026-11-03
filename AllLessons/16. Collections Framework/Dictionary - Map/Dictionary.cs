namespace FirstProgram._16._Collections_Framework.Dictionary___Map;

public class Dictionary
{
    public static void Run()
    {
        Dictionary<int, string> students = new()
        {
            { 1001, "Piseth Mao" }, { 1002, "Phaneth Mao" }, { 1003, "Pisal Mao" }
        };
        Console.WriteLine(students[1001]);
        students[1002] = "Samat Mean";
        if (students.TryGetValue(1003, out var name))
        {
            Console.WriteLine(name);
        }

        students.Remove(1001);
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} - {student.Value}");
        }
    }
}