namespace FirstProgram._18._Exceptions.Null___Collection;

public class KeyNotFound
{
    public static void Run()
    {
        try
        {
            var students = new Dictionary<int, string>
            {
                { 1, "Piseth" },
                { 2, "Pisal" }
            };
            Console.WriteLine(students[4]);
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine($"KeyNotFoundException: {e.Message}");
        }
    }
}