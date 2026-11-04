using System.IO.Compression;
using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class GZipStreamDemo
{
    public static void Run()
    {
        const string path = "message.txt.gz";
        var text = string.Concat(
            Enumerable.Repeat("Hello From C# Compression.\n", 100));
        var original = Encoding.UTF8.GetBytes(text);
        using (var fs = File.Create(path))
        using (GZipStream gzip = new(fs, CompressionMode.Compress, true))
        {
            gzip.Write(original, 0, original.Length);
        }

        var compressedSize = new FileInfo(path).Length;
        Console.WriteLine($"Original size: {original.Length} bytes");
        Console.WriteLine($"Compressed Size: {compressedSize} bytes");
        using var combined = File.OpenRead(path);
        using GZipStream decompressed = new(combined, CompressionMode.Decompress);
        using MemoryStream compressed = new();
        decompressed.CopyTo(compressed);
        var result = Encoding.UTF8.GetString(compressed.ToArray());
        Console.WriteLine($"Decompressed: {result == text}");
    }
}