namespace FirstProgram._18._Exceptions.File_Input_Output_Exceptions;

public class FileNotFound
{
    public static void Run()
    {
        try
        {
            var content = File.ReadAllText("missing-file.txt");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"FileNotFoundException: {e.Message}");
        }
    }
}