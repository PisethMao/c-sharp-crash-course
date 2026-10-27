namespace FirstProgram._3._Data_Types.Reference.Interface;

public class PaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount}");
    }
}