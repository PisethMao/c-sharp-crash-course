namespace FirstProgram._18._Exceptions.Network___Asynchronous;

public class Aggregate
{
    public static void Run()
    {
        var task = Task.Run(() => { throw new InvalidOperationException("Background Task Failed."); });
        try
        {
            task.Wait();
        }
        catch (AggregateException e)
        {
            foreach (var innerException in e.InnerExceptions)
            {
                Console.WriteLine($"InnerException: {innerException.GetType().Name}");
                Console.WriteLine($"Message: {innerException.Message}");
            }
        }
    }
}