namespace FirstProgram._3._Data_Types.Value.Floating_Point;

public class FloatingPoint
{
    public static void Run()
    {
        const float f = 1.23f;
        const double d = 1.23;
        const decimal dec = 1.23m;
        
        Console.WriteLine($"Float is: {f}");
        Console.WriteLine($"Double is: {d}");
        Console.WriteLine($"Decimal is: {dec}");
    }
}