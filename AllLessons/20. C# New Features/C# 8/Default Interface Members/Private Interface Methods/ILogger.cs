namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Private_Interface_Methods;

public interface ILogger
{
    private static void WriteLog(string level, string message)
    {
        Console.WriteLine($"[{level}] {message}");
    }

    void LogInformation(string message)
    {
        WriteLog("INFO", message);
    }

    void LogWarning(string message)
    {
        WriteLog("WARN", message);
    }

    void LogError(string message)
    {
        WriteLog("ERROR", message);
    }
}