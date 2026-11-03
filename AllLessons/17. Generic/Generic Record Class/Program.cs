namespace FirstProgram._17._Generic.Generic_Record_Class;

public class Program
{
    public static void Run()
    {
        var response1 = new ApiResponse<string>(
            true, "Success", "Hello World!"
        );
        var response2 = new ApiResponse<int>(
            true, "Success", 100
        );
        Console.WriteLine(response1.Data);
        Console.WriteLine(response1.Message);
        Console.WriteLine(response1.Success);
        Console.WriteLine(response2.Data);
        Console.WriteLine(response2.Message);
        Console.WriteLine(response2.Success);
    }
}