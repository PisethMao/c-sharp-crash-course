namespace FirstProgram._6._Comments;

public class MultiLine
{
    public static void Run()
    {
        /*
         * This program calculates
         * the total price of a product
         * including tax.
         */
        decimal price = 100m;
        decimal taxRate = 0.1m;
        
        decimal total = price + (price * taxRate);
        Console.WriteLine($"The total price is {total}");
    }
}