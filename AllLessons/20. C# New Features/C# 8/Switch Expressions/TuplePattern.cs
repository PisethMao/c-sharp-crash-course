namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class TuplePattern
{
    public static void Run()
    {
        const bool isLoggedIn = true;
        const string role = "ADMIN";
        var result = (isLoggedIn, role) switch
        {
            (true, "ADMIN") => "Admin Dashboard",
            (true, "USER") => "User Dashboard",
            (false, _) => "Please Login",
            _ => "Access Denied"
        };
        Console.WriteLine($"Result: {result}");
    }
}