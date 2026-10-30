namespace FirstProgram._13._Access_Modifiers.Private;

public class BankAccount
{
    private decimal _balance = 100m;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }
    public decimal GetBalance()
    {
        return _balance;
    }
}