namespace FirstProgram._17._Generic.Generic_Class;

public class Program
{
    public static void Run()
    {
        var numbers = new Storage<int>(5);
        Console.WriteLine(numbers.GetDefault());
        numbers.SetDefault(5);
        Console.WriteLine(numbers.GetDefault());
        var message = new Storage<string>("Hello World");
        Console.WriteLine(message.GetDefault());
    }
}