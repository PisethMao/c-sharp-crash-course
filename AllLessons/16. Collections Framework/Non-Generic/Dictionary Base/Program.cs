namespace FirstProgram._16._Collections_Framework.Non_Generic.Dictionary_Base;

public class Program
{
    public static void Run()
    {
        StudentMap studentMap = new()
        {
            { 1001, "John Doe" },
            { 1002, "Jane Doe" },
        };
        Console.WriteLine(studentMap.Get(1002));
    }
}