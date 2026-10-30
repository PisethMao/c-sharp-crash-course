namespace FirstProgram._5._Operators;

public class Other
{
    public static void Run()
    {
        // Lambda
        Console.WriteLine(Square(5));
        // Sizeof
        Console.WriteLine(sizeof(byte));
        Console.WriteLine(sizeof(short));
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(long));
        Console.WriteLine(sizeof(ushort));
        Console.WriteLine(sizeof(uint));
        Console.WriteLine(sizeof(ulong));
        Console.WriteLine(sizeof(float));
        Console.WriteLine(sizeof(double));
        Console.WriteLine(sizeof(decimal));
        Console.WriteLine(sizeof(char));
        Console.WriteLine(sizeof(sbyte));
        Console.WriteLine(sizeof(bool));
        // Nameof
        const string username = "Piseth Mao";
        Console.WriteLine(nameof(username));
        Console.WriteLine(username);
        Console.WriteLine(nameof(Other));
        return;
        int Square(int x) => x * x;
    }
}