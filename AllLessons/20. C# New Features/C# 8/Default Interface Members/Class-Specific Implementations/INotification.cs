namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Class_Specific_Implementations;

public interface INotification
{
    void Send(string message)
    {
        Console.WriteLine($"Default Notification: {message}");
    }
}