namespace FirstProgram._5._Operators;

public class Bitwise
{
    public static void Run()
    {
        const int a = 5;
        const int b = 3;
        
        Console.WriteLine(a & b);
        Console.WriteLine(a ^ b);
        Console.WriteLine(a | b);
        Console.WriteLine(~a);
    }
}