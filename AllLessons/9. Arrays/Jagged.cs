namespace FirstProgram._9._Arrays;

public class Jagged
{
    public static void Run()
    {
        var numbers = new int[3][];

        numbers[0] = [1, 2, 3];
        numbers[1] = [4, 5];
        numbers[2] = [6, 7, 8, 9];

        Console.WriteLine(numbers[0][0]); // 1
        Console.WriteLine(numbers[1][1]); // 5
        Console.WriteLine(numbers[2][3]); // 9
    }
}