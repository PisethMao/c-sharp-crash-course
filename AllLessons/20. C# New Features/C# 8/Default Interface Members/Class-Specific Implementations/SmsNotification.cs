namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Class_Specific_Implementations;

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sms: {message}");
    }
}