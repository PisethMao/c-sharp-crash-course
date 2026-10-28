namespace FirstProgram._10._Method;

public class CardPaymentService : PaymentService
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Card Payment Service: ${amount}");
    }
}