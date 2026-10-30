namespace FirstProgram._14._OOP.Polymorphism.Compile_Time;

public readonly struct OperatorOverloading(decimal amount)
{
    public decimal Amount { get; } = amount;

    public static OperatorOverloading operator 
        +(OperatorOverloading left, OperatorOverloading right)
    {
        return new OperatorOverloading(left.Amount + right.Amount);
    }
}