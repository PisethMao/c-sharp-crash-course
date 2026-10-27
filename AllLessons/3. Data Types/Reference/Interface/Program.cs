namespace FirstProgram._3._Data_Types.Reference.Interface;

public class Program
{
    public static void Run()
    {
        IPaymentService paymentService = new PaymentService();
        paymentService.ProcessPayment(100);
    }
}