namespace FirstProgram._14._OOP.Abstraction.Abstract_Class;

public abstract class PaymentProcessor
{
    protected static void Validate(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than zero");
        }
    }
    
    public abstract void Pay(decimal amount);
}