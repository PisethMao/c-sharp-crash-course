namespace FirstProgram._20._C__New_Features.C__8.Positional_Patterns.Property;

public record Employee(string Name, int Age)
{
    public string Department { get; init; } = "";
}