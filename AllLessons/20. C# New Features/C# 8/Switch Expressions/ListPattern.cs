namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class ListPattern
{
    public static void Run()
    {
        int[] numbers = [1, 2, 3, 4];
        var result = numbers switch
        {
            [] => "Empty Array",
            [var only] => $"One Element: {only}",
            [1, 2] => "Exactly 1 and 2",
            [1, ..] => "Starts with 1",
            [_, _, ..] => "At least 2 elements",
            _ => "Other Array"
        };
        Console.WriteLine($"Result: {result}");
    }
}