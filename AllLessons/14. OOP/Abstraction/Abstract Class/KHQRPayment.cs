namespace FirstProgram._14._OOP.Abstraction.Abstract_Class;

public class KhqrPayment : PaymentProcessor
{
    public override void Pay(decimal amount)
    {
        Validate(amount);
        Console.WriteLine($"KHQR Payment is = ${amount}");
    }
}