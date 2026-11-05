namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Events;

public class NotificationService : INotifier
{
    public event Action? NotificationReceived;

    public void SendNotification()
    {
        Console.WriteLine("SendNotification called!");
        NotificationReceived?.Invoke();
    }
}