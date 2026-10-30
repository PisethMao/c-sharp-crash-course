namespace FirstProgram._14._OOP.Abstraction.Abstract_Class;

public class CardPayment : PaymentProcessor
{
    public override void Pay(decimal amount)
    {
        Validate(amount);
        Console.WriteLine($"Card Payment is = ${amount}");
    }
}