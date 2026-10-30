namespace FirstProgram._3._Data_Types.Value.Integer;

public class Integer
{
    public static void Run()
    {
        const sbyte s = 10;
        const byte b = 10;
        const short sh = 10;
        const ushort us = 10;
        const int i = 10;
        const uint ui = 10;
        const long l = 10;
        const ulong ul = 10;
        const nint ni = 10;
        const nuint nu = 10;
        
        Console.WriteLine($"sbyte: {s}");
        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {sh}");
        Console.WriteLine($"ushort: {us}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"uint: {ui}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"ulong: {ul}");
        Console.WriteLine($"nint: {ni}");
        Console.WriteLine($"nuint: {nu}");
    }
}