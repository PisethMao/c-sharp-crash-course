namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Derived_Interface_Implementations;

public class InterfaceInheritanceDemo
{
    public static void Run()
    {
        IMessage message = new EmailService();
        message.Send();
    }
}