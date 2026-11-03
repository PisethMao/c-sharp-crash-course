namespace FirstProgram._17._Generic.Generic_Constraints.Struct;

public class Program
{
    public static void Run()
    {
        var number = new NumberStorage<int> { Value = 1 };
        var price = new NumberStorage<decimal> { Value = 0.1m };
        Console.WriteLine(price.Value);
        Console.WriteLine(number.Value);
    }
}