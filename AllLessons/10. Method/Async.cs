namespace FirstProgram._10._Method;

public class Async
{
    private static async Task<string> GetUserAsync()
    {
        await Task.Delay(1000);
        return "Hello World";
    }
    
    private static async Task TaskRun()
    {
        var name = await GetUserAsync();
        Console.WriteLine(name);
    }

    public static void Run()
    {
        TaskRun().GetAwaiter().GetResult();
    }
}