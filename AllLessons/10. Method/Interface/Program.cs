namespace FirstProgram._10._Method.Interface;

public class Program
{
    public static void Run()
    {
        IPaymentService paymentService = new BakongPaymentService();
        paymentService.Pay(200m);
    }
}