namespace FirstProgram._10._Method;

public class Instance
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount));
        Balance += amount;
    }

    public decimal GetBalance()
    {
        return Balance;
    }

    public static void Run()
    {
        Instance instance = new Instance();
        instance.Deposit(100);
        instance.Deposit(200);
        Console.WriteLine(instance.GetBalance());
    }
}