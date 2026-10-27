namespace FirstProgram._4._Casting;

public class Unboxing
{
    public static void Run()
    {
        object boxedNumber = 100;
        int unboxedNumber = (int)boxedNumber;

        Console.WriteLine($"Boxed Number: {boxedNumber}");
        Console.WriteLine($"Unboxed Number: {unboxedNumber}");
    }
}