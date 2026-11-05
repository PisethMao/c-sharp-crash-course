namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions;

public class TypePattern
{
    public static void Run()
    {
        Console.Write("Enter a value: ");
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        object value;
        if (int.TryParse(input, out var intValue))
        {
            value = intValue;
        }
        else if (double.TryParse(input, out var doubleValue))
        {
            value = doubleValue;
        }
        else if (bool.TryParse(input, out var boolValue))
        {
            value = boolValue;
        }
        else
        {
            value = input;
        }

        var result = value switch
        {
            int => "Integer Value",
            double => "Double Value",
            string => "String Value",
            bool => "Boolean Value",
            _ => "Unknown Value"
        };
        Console.WriteLine($"Result is: {result}");
    }
}