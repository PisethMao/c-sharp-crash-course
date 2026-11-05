namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Class_Specific_Implementations;

public class OverrideDefaultDemo
{
    public static void Run()
    {
        INotification email = new EmailNotification();
        INotification sms = new SmsNotification();
        email.Send("Send");
        sms.Send("Send");
    }
}