namespace FirstProgram._5._Operators;

public class Shift
{
    public static void Run()
    {
        const int number = 8;
        
        Console.WriteLine(number << 1);
        Console.WriteLine(number >> 1);
        Console.WriteLine(number >>> 1);
    }
}