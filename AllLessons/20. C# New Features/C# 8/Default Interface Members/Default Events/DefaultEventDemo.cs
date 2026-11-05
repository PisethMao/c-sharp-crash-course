namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Events;

public static class DefaultEventDemo
{
    public static void Run()
    {
        NotificationService notificationService = new();
        INotifier notifier = notificationService;
        var handler = () => { Console.WriteLine("Notification Received!"); };
        notifier.Notified += handler;
        notificationService.SendNotification();
        notifier.Notified -= handler;
        notificationService.SendNotification();
    }
}