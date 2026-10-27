namespace FirstProgram._5._Operators;

public class NullRelated
{
    public static void Run()
    {
        // Null-Coalescing Operator
        string? username = null;
        string result = username ?? "Guest";
        Console.WriteLine(result);
        // Null-Coalescing Assignment
        string? name = null;
        name ??= "Guest";
        Console.WriteLine(name);
        // Null-Conditional Operator
        string? firstName = null;
        int? length = firstName?.Length;
        Console.WriteLine(length);
        // Null-Conditional Element Access Operator
        int[]? numbers = null;
        int? number = numbers?[0];
        Console.WriteLine(number);
    }
}