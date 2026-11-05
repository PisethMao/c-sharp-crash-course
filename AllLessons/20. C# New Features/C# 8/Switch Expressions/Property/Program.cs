namespace FirstProgram._20._C__New_Features.C__8.Switch_Expressions.Property;

public class Program
{
    public static void Run()
    {
        PropertyPattern pattern = new(21, 100);
        // var result = pattern switch
        // {
        //     { Score: >= 90 } => "Excellent",
        //     { Score: >= 80 } => "Very Good",
        //     { Score: >= 70 } => "Good",
        //     { Score: >= 60 } => "A little Good",
        //     { Score: >= 50 } => "Weak",
        //     _ => "Needs Improvement"
        // };
        var result = pattern switch
        {
            { Age: >= 18, Score: >= 90 } => "Adult Honor Student",
            { Age: < 18, Score: >= 90 } => "Young Honor Student",
            _ => "Regular Honor Student"
        };
        Console.WriteLine($"Result: {result}");
    }
}