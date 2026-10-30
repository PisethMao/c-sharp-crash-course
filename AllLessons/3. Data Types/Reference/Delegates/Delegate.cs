namespace FirstProgram._3._Data_Types.Reference.Delegates;

public class Delegate
{
    // private delegate int Calculate(int a, int b);

    public static void Run()
    {
        // Calculate add = (a, b) => a + b;
        // Calculate multiply = (a, b) => a * b;
        
        Console.WriteLine(Add(2, 3));
        Console.WriteLine(Multiply(2, 3));
        return;
        int Add(int a, int b) => a + b;
        int Multiply(int a, int b) => a * b;
    }
}