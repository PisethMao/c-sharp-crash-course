namespace FirstProgram._5._Operators;

public class Bitwise
{
    public static void Run()
    {
        int a = 5;
        int b = 3;
        
        Console.WriteLine(a & b);
        Console.WriteLine(a ^ b);
        Console.WriteLine(a | b);
        Console.WriteLine(~a);
    }
}