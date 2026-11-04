using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class MemoryStreamDemo
{
    public static void Run()
    {
        using MemoryStream stream = new();
        const string message = "Hello C# Memory Stream!";
        var data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Data Length: {stream.Length}");
        Console.WriteLine($"Data Position: {stream.Position}");
        stream.Position = 0;
        var buffer = new byte[data.Length];
        // stream.ReadExactly(buffer);
        stream.ReadExactly(buffer, 0, buffer.Length);
        var text = Encoding.UTF8.GetString(buffer);
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Data Length: {stream.Length}");
        Console.WriteLine($"Data Position: {stream.Position}");
    }
}