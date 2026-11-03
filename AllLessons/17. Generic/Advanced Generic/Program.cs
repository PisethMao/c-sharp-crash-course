namespace FirstProgram._17._Generic.Advanced_Generic.Multiple_Generic;

public class Program
{
    public static void Run()
    {
        var data = new KeyValue<int, string>(1, "Piseth");
        Console.WriteLine(data.Key);
        Console.WriteLine(data.Value);
    }
}