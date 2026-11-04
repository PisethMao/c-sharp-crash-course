namespace FirstProgram._18._Exceptions.File_Input_Output_Exceptions;

public class DirectoryNotFound
{
    public static void Run()
    {
        try
        {
            var content = File.ReadAllText("missing-folder/data.txt");
            Console.WriteLine(content);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine($"DirectoryNotFound: {e.Message}");
        }
    }
}