namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class LogicalTuple
{
    public static void Run()
    {
        const string role = "Manager";
        const bool isActive = true;
        var access = (role, isActive) switch
        {
            ("Admin" or "Manager", true) => "Privileged Access",
            (not "Guest", true) => "Standard Access",
            _ => "Access Denied"
        };
        Console.WriteLine($"Access: {access}");
    }
}