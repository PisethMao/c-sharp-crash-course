namespace FirstProgram._4._Casting;

public class ParseExample
{
    public static void Run()
    {
        const string age = "25";
        var result = int.Parse(age);

        Console.WriteLine($"age: {result}");
        Console.WriteLine($"Type: {result.GetType()}");
    }
}