namespace FirstProgram._10._Method;

public static class Extension
{
    public static bool IsLong(this string value)
    {
        return value.Length > 10;
    }
    
    public static void Run()
    {
        string name = "Piseth Mao";
        bool isResult = name.IsLong();
        Console.WriteLine(isResult);
    }
}