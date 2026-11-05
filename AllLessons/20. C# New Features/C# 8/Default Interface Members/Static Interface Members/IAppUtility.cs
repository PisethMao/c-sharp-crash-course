namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Static_Interface_Members;

public interface IAppUtility
{
    public const string Prefix = "[APP]";

    public static string Format(string message)
    {
        return $"{Prefix} {message}";
    }

    public static string AppName => "My Application";
}