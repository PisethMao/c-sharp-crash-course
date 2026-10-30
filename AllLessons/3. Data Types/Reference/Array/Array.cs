namespace FirstProgram._3._Data_Types.Reference.Array;

public class Array
{
    public static void Run()
    {
        int[] scores = [ 85, 92, 78, 90, 88 ];
        
        // Console.WriteLine($"Scores are: {string.Join(", ", scores)}");
        Console.WriteLine($"Scores length is: {scores.Length}");
        Console.WriteLine($"Scores first element is: {scores[0]}");
    }
}