namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.References;

public static class ReadonlyRefParameter
{
    private static int DoubleValue(ref readonly int value)
    {
        return value * 2;
    }

    public static void Run()
    {
        var number = 50;
        var result = DoubleValue(in number);
        Console.WriteLine(result);
    }
}