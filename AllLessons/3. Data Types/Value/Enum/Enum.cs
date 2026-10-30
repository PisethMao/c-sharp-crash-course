namespace FirstProgram._3._Data_Types.Value.Enum;

public class Enum
{
    private enum Transaction
    {
        Pending,
        Success,
        Failed
    }
    
    public static void Run()
    {
        const Transaction t = Transaction.Pending;
        const Transaction t2 = Transaction.Success;
        const Transaction t3 = Transaction.Failed;

        Console.WriteLine(t);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
    }
}