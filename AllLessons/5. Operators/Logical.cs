namespace FirstProgram._5._Operators;

public class Logical
{
    public static void Run()
    {
        Console.Write("Enter your age: ");
        if (!int.TryParse(Console.ReadLine(), out var age))
        {
            Console.WriteLine("Invalid age.");
            return;
        }

        Console.Write("Do you have an ID? (true/false): ");
        if (!bool.TryParse(Console.ReadLine(), out var hasId))
        {
            Console.WriteLine("Invalid answer.");
            return;
        }

        Console.WriteLine(age >= 18 && hasId);
        Console.WriteLine(age >= 18 || hasId);
        Console.WriteLine(!hasId);
    }
}