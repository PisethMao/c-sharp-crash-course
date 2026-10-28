namespace FirstProgram._9._Arrays;

public class Jagged
{
    public static void Run()
    {
        int[][] numbers = new int[3][];
        numbers[0] = new int[] { 1, 2, 3 };
        numbers[1] = new int[] { 4, 5, 6 };
        numbers[2] = new int[] { 7, 8, 9 };
        
        Console.WriteLine(numbers[0][1]);
        Console.WriteLine(numbers[1][2]);
    }
}