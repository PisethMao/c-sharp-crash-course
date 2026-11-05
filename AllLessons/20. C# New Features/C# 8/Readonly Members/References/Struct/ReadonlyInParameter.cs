namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.References.Struct;

public readonly struct ReadonlyInParameter(double x, double y)
{
    public double X { get; } = x;
    public double Y { get; } = y;
}