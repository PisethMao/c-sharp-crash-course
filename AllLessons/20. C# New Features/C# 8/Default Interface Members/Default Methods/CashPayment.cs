namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Methods;

public class CashPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"CashPayment: ${amount}");
    }
}