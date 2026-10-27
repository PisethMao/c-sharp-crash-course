namespace FirstProgram._4._Casting;

public class ParseExample
{
    public static void Run()
    {
        string age = "25";
        int result = int.Parse(age);

        Console.WriteLine($"age: {result}");
        Console.WriteLine($"Type: {result.GetType()}");
    }
}