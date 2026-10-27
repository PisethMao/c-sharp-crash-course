namespace FirstProgram._4._Casting;

public class Boxing
{
    public static void Run()
    {
        int number = 100;
        object boxedNumber = number;
        int unboxedNumber = (int)boxedNumber;

        Console.WriteLine($"Boxed Number: {boxedNumber}");
        Console.WriteLine($"Unboxed Number: {unboxedNumber}");
    }
}