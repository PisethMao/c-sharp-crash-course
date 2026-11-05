namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions.Positional;

public class Program
{
    public static void Run()
    {
        PositionalPattern p = new(0, 5);
        var result = p switch
        {
            (0, 0) => "Origin",
            (0, _) => "Y-axis",
            (_, 0) => "X-axis",
            (> 0, > 0) => "First quadrant",
            _ => "Other Positional Pattern"
        };
        Console.WriteLine($"Result: {result}");
    }
}