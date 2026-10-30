namespace FirstProgram._4._Casting;

public class AsExample
{
    public static void Run()
    {
        object value = "Hello, C#";
        var result = value as string;
        
        Console.WriteLine(result);
    }
}