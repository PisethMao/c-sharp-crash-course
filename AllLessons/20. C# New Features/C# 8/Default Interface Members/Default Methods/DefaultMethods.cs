namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Methods;

public class DefaultMethods
{
    public static void Run()
    {
        IPayment payment = new CashPayment();
        payment.Pay(100m);
        payment.PrintReceipt(200m);
    }
}