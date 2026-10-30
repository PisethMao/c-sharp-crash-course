namespace FirstProgram._4._Casting;

public class ConvertExample
{
    public static void Run()
    {
        const string number = "100";
        const double price = 99.99;
        const bool isActive = true;
        
        var result1 = Convert.ToInt32(number);
        var result2 = Convert.ToInt32(price);
        var result3 = Convert.ToInt32(isActive);
        
        Console.WriteLine($"result1: {result1}");
        Console.WriteLine($"result2: {result2}");
        Console.WriteLine($"result3: {result3}");
    }
}