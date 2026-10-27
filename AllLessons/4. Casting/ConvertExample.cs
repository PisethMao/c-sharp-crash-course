namespace FirstProgram._4._Casting;

public class ConvertExample
{
    public static void Run()
    {
        string number = "100";
        double price = 99.99;
        bool isActive = true;
        
        int result1 = Convert.ToInt32(number);
        int result2 = Convert.ToInt32(price);
        int result3 = Convert.ToInt32(isActive);
        
        Console.WriteLine($"result1: {result1}");
        Console.WriteLine($"result2: {result2}");
        Console.WriteLine($"result3: {result3}");
    }
}