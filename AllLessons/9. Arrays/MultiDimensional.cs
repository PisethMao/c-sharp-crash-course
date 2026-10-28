namespace FirstProgram._9._Arrays;

public class MultiDimensional
{
    public static void Run()
    {
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine(matrix[0, 0]);
        Console.WriteLine(matrix[1, 0]);
        Console.WriteLine(matrix[2, 0]);
    }
}