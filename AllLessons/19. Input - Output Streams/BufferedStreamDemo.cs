using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class BufferedStreamDemo
{
    public static void Run()
    {
        const string path = "buffered.txt";
        using (FileStream fs = new(path, FileMode.Create, FileAccess.Write))
        using (BufferedStream stream = new(fs, bufferSize: 4096))
        {
            for (var i = 1; i <= 10; i++)
            {
                var message = $"Message {i}\n";
                var bytes = Encoding.UTF8.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
            }

            stream.Flush();
        }

        using (var fs = File.OpenRead(path))
        using (BufferedStream stream = new(fs, 4096))
        using (StreamReader reader = new(stream, Encoding.UTF8, leaveOpen: true))
        {
            var message = reader.ReadToEnd();
            Console.WriteLine(message);
        }
    }
}