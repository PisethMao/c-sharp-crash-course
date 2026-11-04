namespace FirstProgram._18._Exceptions.Network___Asynchronous;

public class OperationCancelled
{
    public static void Run()
    {
        using var cts = new CancellationTokenSource();
        try
        {
            cts.Cancel();
            cts.Token.ThrowIfCancellationRequested();
        }
        catch (OperationCanceledException e)
        {
            Console.WriteLine($"OperationCanceledException: {e.Message}");
        }
    }
}