namespace FirstProgram._5._Operators;

public class NullRelated
{
    public static void Run()
    {
        // Null-Coalescing Operator
        string? username = null;
        var result = username ?? "Guest";
        Console.WriteLine(result);
        // Null-Coalescing Assignment
        string? name = null;
        name ??= "Guest";
        Console.WriteLine(name);
        // Null-Conditional Operator
        string? firstName = null;
        var length = firstName?.Length;
        Console.WriteLine(length);
        // Null-Conditional Element Access Operator
        int[]? numbers = null;
        var number = numbers?[0];
        Console.WriteLine(number);
    }
}