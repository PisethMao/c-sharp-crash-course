namespace FirstProgram._18._Exceptions.Network___Asynchronous;

public class TaskCancelled
{
    private static async Task RunAsync()
    {
        using var cts = new CancellationTokenSource();
        try
        {
            await cts.CancelAsync();
            await Task.Delay(3000, cts.Token);
            Console.WriteLine("Task Completed Successfully");
        }
        catch (TaskCanceledException e)
        {
            Console.WriteLine($"TaskCanceledException: {e.Message}");
        }
    }

    public static void Run()
    {
        RunAsync().GetAwaiter().GetResult();
    }
}