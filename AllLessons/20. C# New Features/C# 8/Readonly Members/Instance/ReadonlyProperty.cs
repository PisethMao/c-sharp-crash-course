namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Instance;

public class ReadonlyProperty(decimal balance)
{
    private decimal Balance { get; } = balance;

    public static void Run()
    {
        ReadonlyProperty readonlyProperty = new(1000m);
        Console.WriteLine(readonlyProperty.Balance);
        // readonlyProperty.Balance = 456m;
        // Console.WriteLine(readonlyProperty.Balance);
    }
}