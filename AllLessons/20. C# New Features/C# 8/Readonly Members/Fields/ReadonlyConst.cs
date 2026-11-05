namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Fields;

public class ReadonlyConst
{
    private const double Pi = 3.141592653589793;
    private static readonly DateTime CreatedAt = DateTime.UtcNow;

    public static void Run()
    {
        Console.WriteLine($"PI = {Pi}");
        Console.WriteLine($"Created at: {CreatedAt}");
    }
}