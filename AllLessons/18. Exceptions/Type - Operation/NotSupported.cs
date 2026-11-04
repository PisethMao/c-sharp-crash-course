namespace FirstProgram._18._Exceptions.Type___Operation;

public class NotSupported
{
    private static void Export(string format)
    {
        if (format != "PDF")
        {
            throw new
                NotSupportedException($"Export format {format} is not supported.");
        }

        Console.WriteLine("Exporting PDF...");
    }

    public static void Run()
    {
        try
        {
            Export("XML");
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine($"Not supported: {e.Message}");
        }
    }
}