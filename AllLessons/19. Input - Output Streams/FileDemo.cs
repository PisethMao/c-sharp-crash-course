using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class FileDemo
{
    public static void Run()
    {
        const string directory = "data";
        Directory.CreateDirectory(directory);
        var path = Path.Combine(directory, "test.txt");
        File.WriteAllText(path, "Hello World!\n", Encoding.UTF8);
        File.AppendAllText(path, "Hello World!\n", Encoding.UTF8);
        File.AppendAllText(path, "Hello World!\n", Encoding.UTF8);
        if (File.Exists(path))
        {
            Console.WriteLine($"File exists: {path}");
        }

        var lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            Console.WriteLine($"Line: {line}");
        }

        FileInfo fileInfo = new(path);
        Console.WriteLine($"Name: {fileInfo.Name}");
        Console.WriteLine($"File exists: {fileInfo.Exists}");
        Console.WriteLine($"Size: {fileInfo.Length} bytes");
        Console.WriteLine($"Extension: {fileInfo.Extension}");
        Console.WriteLine(Path.GetFullPath(path));
    }
}