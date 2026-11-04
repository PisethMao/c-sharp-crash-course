namespace FirstProgram._19._Input___Output_Streams;

public class AsyncStreamDemo
{
    private static async Task RunAsync()
    {
        const string sourcePath = "source.txt";
        const string destinationPath = "copied.txt";
        await File.WriteAllTextAsync(
            sourcePath, "Hello Async I/O!\nSecond Line.");
        await using (FileStream source = new(
                         sourcePath,
                         FileMode.Open,
                         FileAccess.Read,
                         FileShare.Read,
                         4096,
                         FileOptions.Asynchronous))
        await using (FileStream destination = new(
                         destinationPath,
                         FileMode.Create,
                         FileAccess.Write,
                         FileShare.None,
                         4096,
                         FileOptions.Asynchronous))
        {
            await source.CopyToAsync(destination);
        }

        var result = await File.ReadAllTextAsync(destinationPath);
        Console.WriteLine(result);
    }

    public static void Run()
    {
        RunAsync().GetAwaiter().GetResult();
    }
}