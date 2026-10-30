namespace FirstProgram._14._OOP.Abstraction.Interface;

public class CardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount}");
    }
}