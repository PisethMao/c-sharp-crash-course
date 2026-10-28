namespace FirstProgram._10._Method.Interface;

public class BakongPaymentService : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount}");
    }
}