namespace FirstProgram._18._Exceptions.Custom_Exceptions;

public static class BankService
{
    public static void Withdraw(decimal balance, decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount),
                "Amount must be greater than zero and positive.");
        }

        if (amount > balance)
        {
            throw new InsufficientBalanceException("Insufficient balance");
        }

        Console.WriteLine($"Withdrawing {balance} with {amount} amount successful");
    }
}