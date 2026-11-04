namespace FirstProgram._18._Exceptions.Network___Asynchronous;

public class HttpRequest
{
    private static readonly HttpClient Client = new()
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    private static async Task RunAsync()
    {
        try
        {
            using var message = await Client.GetAsync(
                "https://example.com/api");
            message.EnsureSuccessStatusCode();
            Console.WriteLine("Request successful");
            Console.WriteLine($"Status code: {(int)message.StatusCode}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request failed: {e.Message}");
            Console.WriteLine($"Status Code: {e.StatusCode}");
        }
        catch (TaskCanceledException e)
        {
            Console.WriteLine($"Request canceled: {e.Message}");
        }
    }

    public static void Run()
    {
        RunAsync().GetAwaiter().GetResult();
    }
}