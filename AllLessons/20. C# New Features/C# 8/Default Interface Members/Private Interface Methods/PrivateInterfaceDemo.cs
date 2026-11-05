namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Private_Interface_Methods;

public class PrivateInterfaceDemo
{
    public static void Run()
    {
        ILogger logger = new ConsoleLogger();
        logger.LogInformation("Application is starting up!");
        logger.LogWarning("Application is waiting for user input.");
        logger.LogError("Database connection is failed!");
    }
}