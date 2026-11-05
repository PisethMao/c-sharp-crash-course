namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Properties;

public class InitOnly
{
    private int Id { get; init; }
    private string Name { get; init; } = string.Empty;

    public static void Run()
    {
        InitOnly instance = new() { Id = 1, Name = "Hello" };
        Console.WriteLine(instance.Id);
        Console.WriteLine(instance.Name);
        // instance.Id = 2;
    }
}