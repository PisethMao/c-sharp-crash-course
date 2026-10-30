namespace FirstProgram._10._Method.Abstract;

public class Program
{
    public static void Run()
    {
        PaymentService paymentService = new CardPaymentService();
        paymentService.Pay(100);
    }
}