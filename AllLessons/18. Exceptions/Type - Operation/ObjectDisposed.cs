namespace FirstProgram._18._Exceptions.Type___Operation;

public class ObjectDisposed
{
    public static void Run()
    {
        try
        {
            var stream = new MemoryStream();
            stream.Dispose();
            Console.WriteLine(stream.Length);
        }
        catch (ObjectDisposedException e)
        {
            Console.WriteLine($"ObjectDisposedException: {e.Message}");
        }
    }
}