namespace FirstProgram._3._Data_Types.Reference.Delegates;

public class Delegate
{
    public delegate int Calculate(int a, int b);

    public static void Run()
    {
        Calculate add = (a, b) => a + b;
        Calculate multiply = (a, b) => a * b;
        
        Console.WriteLine(add(2, 3));
        Console.WriteLine(multiply(2, 3));
    }
}