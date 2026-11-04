using System.Text.Json;

namespace FirstProgram._18._Exceptions.Runtime___Serialization;

public class JsonExceptionExample
{
    public static void Run()
    {
        try
        {
            const string json = "{ invalid json }";
            var data = JsonSerializer
                .Deserialize<Dictionary<string, int>>(json);
            Console.WriteLine(data?.Count);
        }
        catch (JsonException e)
        {
            Console.WriteLine($"JsonException: {e.Message}");
        }
    }
}