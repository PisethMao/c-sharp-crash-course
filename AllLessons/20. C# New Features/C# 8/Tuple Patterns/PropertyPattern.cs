namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class PropertyPattern
{
    public static void Run()
    {
        var user = new { Name = "John", Age = 42 };
        const bool isVerified = true;
        var result = (user, isVerified) switch
        {
            ({ Age: >= 18, Name: "John" }, true)
                => "John is a verified an adult",
            ({ Age: >= 18 }, true) => "Verified an Adult",
            ({ Age: < 18 }, _) => "Underage User",
            _ => "Not Verified"
        };
        Console.WriteLine($"Result: {result}");
    }
}