namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Methods;

public interface IPayment
{
    void Pay(decimal amount);

    void PrintReceipt(decimal amount)
    {
        Console.WriteLine($"Receipt: ${amount}");
    }
}