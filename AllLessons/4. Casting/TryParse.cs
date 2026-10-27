namespace FirstProgram._4._Casting;

public class TryParse
{
    public static void Run()
    {
        string input = "123";
        
        if(int.TryParse(input, out int result))
        {
            Console.WriteLine($"Parsed Number: {result}");
        }
        else
        {
            Console.WriteLine("Failed to parse the input.");
        }
    }
}