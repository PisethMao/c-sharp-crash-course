namespace FirstProgram._3._Data_Types.Value.Enum;

public class Enum
{
    enum Transaction
    {
        Pending,
        Success,
        Failed
    }
    
    public static void Run()
    {
        Transaction t = Transaction.Pending;
        Transaction t2 = Transaction.Success;
        Transaction t3 = Transaction.Failed;

        Console.WriteLine(t);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
    }
}