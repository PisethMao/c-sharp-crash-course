namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Properties;

public class PrivateSetter(decimal initialBalance)
{
    private decimal Balance { get; set; } = initialBalance;

    private void Deposit(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        Balance += amount;
    }

    public static void Run()
    {
        PrivateSetter privateSetter = new(100m);
        privateSetter.Deposit(100m);
        Console.WriteLine(privateSetter.Balance);
        privateSetter.Balance = 20m;
    }
}