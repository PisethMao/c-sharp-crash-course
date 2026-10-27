namespace FirstProgram._5._Operators;

public class IndexRange
{
    public static void Run()
    {
        // Index
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Traditional Syntax
        int[] numbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ]; // Modern Syntax
        Console.WriteLine(numbers.Length);
        Console.WriteLine(numbers[^1]);
        Console.WriteLine(numbers[^2]);
        // Range
        int[] numbers2 = [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ];
        int[] selected = numbers2[1..4];
        Console.WriteLine(String.Join(", ", selected));
    }
}