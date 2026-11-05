namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Views;

public class ReadonlyMemoryView
{
    public static void Run()
    {
        int[] numbers = [10, 20, 30];
        ReadOnlySpan<int> view = numbers;
        Console.WriteLine(view[0]);
        Console.WriteLine(view[1]);
        // view[0] = 40;
        numbers[0] = 40;
        Console.WriteLine(view[0]);
    }
}