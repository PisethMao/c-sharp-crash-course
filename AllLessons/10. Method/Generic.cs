namespace FirstProgram._10._Method;

public class Generic
{
    private static T GetValue<T>(T defaultValue)
    {
        return defaultValue;
    }
    
    public static void Run()
    {
        var age = GetValue(17);
        var name = GetValue("Piseth");
        var isMale = GetValue(true);
        Console.WriteLine(age);
        Console.WriteLine(name);
        Console.WriteLine(isMale);
    }
}