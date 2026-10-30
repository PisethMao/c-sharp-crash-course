namespace FirstProgram._10._Method;

public static class Extension
{
    private static bool IsLong(this string value)
    {
        return value.Length > 10;
    }
    
    public static void Run()
    {
        const string name = "Piseth Mao";
        var isResult = name.IsLong();
        Console.WriteLine(isResult);
    }
}