namespace FirstProgram._17._Generic.Generic_Delegate;

public class Program
{
    public static void Run()
    {
        // Action<string> print = message => Console.WriteLine(message);
        // Func<int, int> square = x => x * x;
        // Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine(NumberTransformer(1));
        Console.WriteLine(GetLength("Hello"));
        Print("Hello World!");
        Console.WriteLine(Square(3));
        Console.WriteLine(IsEven(10));
        return;

        // Transformer<int, string> numberTransformer = number => $"Number: {number}";
        string NumberTransformer(int number)
        {
            return $"Number: {number}";
        }

        // Transformer<string, int> transformer = str => str.Length;
        int GetLength(string number)
        {
            return number.Length;
        }

        void Print(string message)
        {
            Console.WriteLine(message);
        }

        int Square(int x)
        {
            return x * x;
        }

        bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}