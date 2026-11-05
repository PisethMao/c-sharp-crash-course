namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class DeclarationTuple
{
    public static void Run()
    {
        object first = 100;
        object second = "Hello";
        var result = (first, second) switch
        {
            (int number, string text) => $"Number: {number}, Text: {text}",
            (string text, int number) => $"Text: {text}, Number: {number}",
            _ => "Unsupported Types"
        };
        Console.WriteLine($"Result: {result}");
    }
}