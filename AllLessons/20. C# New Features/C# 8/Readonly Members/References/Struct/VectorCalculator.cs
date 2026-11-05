namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.References.Struct;

public class VectorCalculator
{
    private static double CalculateLength(in ReadonlyInParameter readonlyInParameter)
    {
        return Math.Sqrt(readonlyInParameter.X * readonlyInParameter.X
                         + readonlyInParameter.Y * readonlyInParameter.Y);
    }

    public static void Run()
    {
        ReadonlyInParameter readonlyInParameter = new(3, 5);
        var result = CalculateLength(in readonlyInParameter);
        Console.WriteLine(result);
    }
}