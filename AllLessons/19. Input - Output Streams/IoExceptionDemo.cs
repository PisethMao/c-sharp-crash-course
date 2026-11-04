namespace FirstProgram._19._Input___Output_Streams;

public class IoExceptionDemo
{
    public static void Run()
    {
        const string path = "nonexistent-demo-file.txt";
        try
        {
            using FileStream fileStream = new(path, FileMode.Open, FileAccess.Read);
            Console.WriteLine("Filestream opened!");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine($"Directory not found: {e.Message}");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"Unauthorized access: {e.Message}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"IO exception: {e.Message}");
        }
    }
}