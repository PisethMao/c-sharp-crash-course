namespace FirstProgram._17._Generic.Generic_Record_Struct;

public class Program
{
    public static void Run()
    {
        var result1 = new Result<int>(100, true);
        var result2 = new Result<string>("Save", true);
        Console.WriteLine(result1.Value);
        Console.WriteLine(result1.IsSuccess);
        Console.WriteLine(result2.IsSuccess);
        Console.WriteLine(result2.Value);
    }
}