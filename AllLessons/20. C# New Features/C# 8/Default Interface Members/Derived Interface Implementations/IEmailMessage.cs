namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Derived_Interface_Implementations;

public interface IEmailMessage : IMessage
{
    void IMessage.Send()
    {
        Console.WriteLine("Sending email message...");
    }
}