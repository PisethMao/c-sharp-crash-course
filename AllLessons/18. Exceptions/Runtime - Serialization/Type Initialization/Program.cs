namespace FirstProgram._18._Exceptions.Runtime___Serialization.Type_Initialization;

public class Program
{
    public static void Run()
    {
        try
        {
            Console.WriteLine(DatabaseConfig.ConnectionString);
        }
        catch (TypeInitializationException e)
        {
            Console.WriteLine($"TypeInitializationException: {e.Message}");
            Console.WriteLine(e.InnerException?.Message);
        }
    }
}