namespace FirstProgram._8._Control_Flow.Iteration;

public class ForEach
{
    public static void Run()
    {
        string[] names = ["Piseth", "Phaneth", "Pisal"];
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}