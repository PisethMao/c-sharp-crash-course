using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class TextStreamDemo
{
    public static void Run()
    {
        const string path = "sample.txt";
        using (StreamWriter writer =
               new(path, append: false, encoding: Encoding.UTF8))
        {
            writer.WriteLine("Hello, World!");
            writer.WriteLine("Cat sound music!");
            writer.WriteLine("Dog sound music!");
            writer.WriteLine("Elephant sound music!");
        }

        Console.WriteLine("Successfully Wrote File");
        using (StreamReader reader = new(path, Encoding.UTF8))
        {
            while (reader.ReadLine() is { } line)
            {
                Console.WriteLine($"Line: {line}");
            }
        }
    }
}