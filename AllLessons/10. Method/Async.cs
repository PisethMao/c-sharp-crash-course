namespace FirstProgram._10._Method;

public class Async
{
    public async Task<string> GetUserAsync()
    {
        await Task.Delay(1000);
        return "Hello World";
    }
    
    public static async Task TaskRun()
    {
        Async user = new Async();
        string name = await user.GetUserAsync();
        Console.WriteLine(name);
    }

    public static void Run()
    {
        TaskRun().GetAwaiter().GetResult();
    }
}