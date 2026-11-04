using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class FileStreamDemo
{
    public static void Run()
    {
        const string path = "filestream-demo.txt";
        using (FileStream fileStream = new(path, FileMode.Create, FileAccess.Write))
        {
            const string message = "Hello FileStream From C#";
            Console.WriteLine($"Filestream path: {path}");
            var bytes = Encoding.UTF8.GetBytes(message);
            fileStream.Write(bytes, 0, bytes.Length);
            Console.WriteLine($"Filestream written: {message}");
            Console.WriteLine($"Filestream length: {fileStream.Length}");
            Console.WriteLine($"Filestream position: {fileStream.Position}");
            Console.WriteLine($"Written: {fileStream.Length} bytes");
        }

        using (FileStream fileStream = new(path, FileMode.Open, FileAccess.Read))
        {
            var buffer = new byte[8];
            using MemoryStream results = new();
            int bytesRead;
            while ((bytesRead = fileStream
                       .Read(buffer, 0, buffer.Length)) > 0)
            {
                results.Write(buffer, 0, bytesRead);
            }

            var result = Encoding.UTF8.GetString(results.ToArray());
            Console.WriteLine($"Filestream read: {result}");
        }
    }
}