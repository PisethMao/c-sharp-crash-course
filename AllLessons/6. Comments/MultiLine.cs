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
        const decimal price = 100m;
        const decimal taxRate = 0.1m;
        
        const decimal total = price + (price * taxRate);
        Console.WriteLine($"The total price is {total}");
    }
}