namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Properties;

public class GetOnly(int id, string name)
{
    private int Id { get; } = id;
    private string Name { get; } = name;

    public static void Run()
    {
        var getOnly = new GetOnly(10, "John Doe");
        Console.WriteLine(getOnly);
        Console.WriteLine(getOnly.Id);
        Console.WriteLine(getOnly.Name);
        // getOnly.Id = 2002;
    }
}