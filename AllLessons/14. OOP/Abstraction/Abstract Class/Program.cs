namespace FirstProgram._14._OOP.Abstraction.Abstract_Class;

public class Program
{
    public static void Run()
    {
        PaymentProcessor khqr = new KhqrPayment();
        PaymentProcessor card = new CardPayment();

        khqr.Pay(100m);
        card.Pay(200m);
    }
}