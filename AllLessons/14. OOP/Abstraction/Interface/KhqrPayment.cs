namespace FirstProgram._14._OOP.Abstraction.Interface;

public class KhqrPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount}");
    }
}