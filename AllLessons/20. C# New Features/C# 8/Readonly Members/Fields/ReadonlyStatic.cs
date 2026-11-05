namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Fields;

public class ReadonlyStatic
{
    private static readonly DateTime StartedAt = DateTime.UtcNow;
    private static readonly Guid ApplicationId = Guid.NewGuid();

    public static void Run()
    {
        Console.WriteLine($"Started at: {StartedAt}");
        Console.WriteLine($"Application Id: {ApplicationId}");
    }
}