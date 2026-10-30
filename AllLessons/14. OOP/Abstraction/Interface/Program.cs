namespace FirstProgram._14._OOP.Abstraction.Interface;

public class Program
{
    public static void Run()
    {
        IPayment payment = new KhqrPayment();

        payment.Pay(100m);
    }
}