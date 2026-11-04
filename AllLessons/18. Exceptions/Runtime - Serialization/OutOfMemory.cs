namespace FirstProgram._18._Exceptions.Runtime___Serialization;

public class OutOfMemory
{
    public static void Run()
    {
        try
        {
            throw new OutOfMemoryException("Simulated memory allocation failure");
        }
        catch (OutOfMemoryException e)
        {
            Console.WriteLine($"OutOfMemoryException: {e.Message}");
        }
    }
}