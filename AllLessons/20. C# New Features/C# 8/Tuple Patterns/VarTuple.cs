namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class VarTuple
{
    public static void Run()
    {
        (string nameof, int score) student = ("John", 42);
        var result = student switch
        {
            (var name, >= 50 and var score) => $"Name: {name} Score: {score}",
            var (name, _) => $"Name {name}"
        };
        Console.WriteLine($"Result: {result}");
    }
}