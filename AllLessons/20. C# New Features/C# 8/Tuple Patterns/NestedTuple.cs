namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class NestedTuple
{
    public static void Run()
    {
        var data = ((10, 20), "OK");
        var result = data switch
        {
            ((10, 20), "OK") => "Exact Match",
            ((_, _), "OK") => "Other Coordinates",
            _ => "Not Okay"
        };
        Console.WriteLine($"Result: {result}");
    }
}