namespace FirstProgram._10._Method;

public class Varags
{
    private static void Sum(params int[] numbers)
    {
        // var total = 0;
        // foreach (var num in numbers)
        // {
        //     total += num;
        // }
        var total = numbers.Sum();
        Console.WriteLine($"Total numbers: {total}");
    }
    public static void Run()
    {
        Sum();
        Sum(10);
        Sum(20, 30);
        Sum(30, 40, 50);
        Sum(40, 50, 60, 70);
    }
}