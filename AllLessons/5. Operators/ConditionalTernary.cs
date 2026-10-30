namespace FirstProgram._5._Operators;

public class ConditionalTernary
{
    public static void Run()
    {
        Console.Write("Enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            var result = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid age.");
        }
    }
}