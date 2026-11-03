namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class Array
{
    public static void Run()
    {
        int[] numbers = [10, 20, 30, 40];
        Console.WriteLine(numbers[0]);
        numbers[1] = 5;
        Console.WriteLine(numbers.Length);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}