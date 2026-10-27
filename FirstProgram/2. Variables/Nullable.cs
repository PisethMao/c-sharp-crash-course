namespace FirstProgram._2._Variables;

public class Nullable
{
    public static void Run()
    {
        int? age = null;
        string? name = null;

        Console.WriteLine($"Age: {age}");
        Console.WriteLine(name ?? "Name is null");
    }
}