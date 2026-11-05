namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class RelationalTuple
{
    public static void Run()
    {
        const int age = 21;
        const int score = 97;
        var result = (age, score) switch
        {
            (< 0, _) => "Invalid Age",
            (_, < 0) => "Invalid Score",
            (>= 18, >= 80) => "Adult with high score",
            (>= 18, >= 50) => "Adult with passing score",
            (< 18, >= 50) => "Minor with passing score",
            _ => "Failed"
        };
        Console.WriteLine($"Result: {result}");
    }
}