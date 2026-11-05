namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Events;

public interface INotifier
{
    event Action? NotificationReceived;

    event Action? Notified
    {
        add
        {
            NotificationReceived += value;
            Console.WriteLine("Handler Registered!");
        }
        remove
        {
            NotificationReceived -= value;
            Console.WriteLine("Handler Unregistered!");
        }
    }
}