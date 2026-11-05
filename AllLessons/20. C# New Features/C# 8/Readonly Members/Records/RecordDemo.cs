namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Records;

public static class RecordDemo
{
    public static void Run()
    {
        StudentRecord first = new(1, "John", 20);
        var second = first with { Id = 2, };
        Console.WriteLine($"First Id: {first.Id}");
        Console.WriteLine($"First Name: {first.Name}");
        Console.WriteLine($"First Age: {first.Age}");
        Console.WriteLine();
        Console.WriteLine($"Second Id: {second.Id}");
        Console.WriteLine($"Second Name: {second.Name}");
        Console.WriteLine($"Second Age: {second.Age}");
        // first.Id = 3;
    }
}