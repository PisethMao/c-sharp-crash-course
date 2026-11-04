namespace FirstProgram._18._Exceptions.Null___Collection;

public class NullReferenceException
{
    public static void Run()
    {
        try
        {
            string? name = null;
            Console.WriteLine(name!.Length);
        }
        catch (System.NullReferenceException e)
        {
            Console.WriteLine($"NullReferenceException: {e.Message}");
        }
    }
}