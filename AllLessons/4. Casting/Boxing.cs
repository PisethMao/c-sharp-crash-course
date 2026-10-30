namespace FirstProgram._4._Casting;

public class Boxing
{
    public static void Run()
    {
        const int number = 100;
        object boxedNumber = number;
        var unboxedNumber = (int)boxedNumber;

        Console.WriteLine($"Boxed Number: {boxedNumber}");
        Console.WriteLine($"Unboxed Number: {unboxedNumber}");
    }
}