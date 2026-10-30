namespace FirstProgram._4._Casting;

public class TryParse
{
    public static void Run()
    {
        const string input = "123";
        
        Console.WriteLine(
            int.TryParse(input, out var result)
                ? $"Parsed Number: {result}"
                : "Failed to parse the input."
        );
    }
}