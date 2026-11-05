namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Static_Interface_Members;

public class StaticInterfaceDemo
{
    public static void Run()
    {
        Console.WriteLine(IAppUtility.Prefix);
        Console.WriteLine(IAppUtility.Format("Server is starting up!"));
        Console.WriteLine(IAppUtility.AppName);
    }
}