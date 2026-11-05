namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.References;

public class ReadonlyRef
{
    private static int _number = 100;
    private static ref readonly int GetNumber() => ref _number;
    private static void UpdateNumber() => _number = 200;

    public static void Run()
    {
        ref readonly var result = ref GetNumber();
        Console.WriteLine(result);
        UpdateNumber();
        Console.WriteLine(result);
        // result = 500;
    }
}