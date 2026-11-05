namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class DeclarationPattern
{
    public static void Run()
    {
        Console.Write("Enter a value: ");
        var input = Console.ReadLine() ?? "";
        object value;
        if (int.TryParse(input, out var intValue))
        {
            value = intValue;
        }
        else if (double.TryParse(input, out var doubleValue))
        {
            value = doubleValue;
        }
        else
        {
            value = input;
        }

        var result = value switch
        {
            int number => $"Integer: {number}",
            string text => $"String Length: {text.Length}",
            double number => $"Double: {number}",
            _ => "Unknown Value"
        };
        Console.WriteLine($"Result is: {result}");
    }
}