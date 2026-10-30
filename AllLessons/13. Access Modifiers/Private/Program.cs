namespace FirstProgram._13._Access_Modifiers.Private;

public class Program
{
    public static void Run()
    {
        var bankAccount = new BankAccount();
        bankAccount.Deposit(200m);
        Console.WriteLine(bankAccount.GetBalance());
    }
}