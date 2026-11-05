namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class ConstantTuple
{
    public static void Run()
    {
        const string day = "Monday";
        const string weather = "Rainy";
        var activity = (day, weather) switch
        {
            ("Monday", "Rainy") => "Stay at home",
            ("Monday", "Sunny") => "Go to school",
            ("Saturday", "Sunny") => "Go Outside",
            _ => "Normal Activity"
        };
        Console.WriteLine($"Activity: {activity}");
    }
}