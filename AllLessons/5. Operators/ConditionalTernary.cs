namespace FirstProgram._5._Operators;

public class ConditionalTernary
{
    public static void Run()
    {
        int age = 20;
        
        string result = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine(result);
    }
}