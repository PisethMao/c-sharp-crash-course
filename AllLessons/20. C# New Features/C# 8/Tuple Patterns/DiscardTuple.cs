namespace FirstProgram._20._C__New_Features.C__8.Tuple_Patterns;

public class DiscardTuple
{
    public static void Run()
    {
        const string status = "SUCCESS";
        const string country = "KH";
        var result = (status, country) switch
        {
            ("SUCCESS", _) => "Transaction Successful",
            ("FAILED", _) => "Transaction Failed",
            (_, "KH") => "Other Cambodia Transaction",
            _ => "Unknown Transaction"
        };
        Console.WriteLine($"Result: {result}");
    }
}