namespace FirstProgram._10._Method;

public class Instance
{
    private decimal Balance { get; set; }

    private void Deposit(decimal amount)
    {
        // if (amount <= 0)
        //     throw new ArgumentOutOfRangeException(nameof(amount));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        Balance += amount;
    }

    private decimal GetBalance()
    {
        return Balance;
    }

    public static void Run()
    {
        var instance = new Instance();
        instance.Deposit(100);
        instance.Deposit(200);
        Console.WriteLine(instance.GetBalance());
    }
}