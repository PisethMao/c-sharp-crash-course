namespace FirstProgram._18._Exceptions.File_Input_Output_Exceptions;

public class IoExceptionExample
{
    public static void Run()
    {
        try
        {
            throw new IOException("Simulated error reading a file.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"IOException: {e.Message}");
        }
    }
}