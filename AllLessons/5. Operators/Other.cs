namespace FirstProgram._5._Operators;

public class Other
{
    public static void Run()
    {
        // Lambda
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));
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
        String username = "Piseth Mao";
        Console.WriteLine(nameof(username));
        Console.WriteLine(username);
        Console.WriteLine(nameof(Other));
    }
}