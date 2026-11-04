namespace FirstProgram._18._Exceptions.File_Input_Output_Exceptions;

public class UnauthorizedAccess
{
    private static void ReadSensitiveFile(bool hasPermission)
    {
        if (!hasPermission)
        {
            throw new UnauthorizedAccessException("Access to this file is denied");
        }
    }

    public static void Run()
    {
        try
        {
            ReadSensitiveFile(false);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"UnauthorizedAccessException: {e.Message}");
        }
    }
}