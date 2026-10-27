namespace FirstProgram._7._Input_Output;

public class Input
{
    public static void Run()
    {
        Console.Write("Enter the first name: ");
        // string firstName = Console.ReadLine();
        // string? firstName = Console.ReadLine();
        string firstName = Console.ReadLine() ?? "";
        Console.Write("Enter the last name: ");
        string? lastName = Console.ReadLine();
        Console.Write("Enter the age: ");
        // string? age = Console.ReadLine();
        // int age = int.Parse(Console.ReadLine());
        // int age = int.Parse(Console.ReadLine()!);
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine($"Your age is: {age}");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        Console.Write("Enter the gender: ");
        string? gender = Console.ReadLine();
        Console.Write("Enter the salary: ");
        decimal salary = decimal.Parse(Console.ReadLine()!);
        Console.Write("Are you active (true/false)? ");
        bool isActive = bool.Parse(Console.ReadLine()!);

        Console.WriteLine($"Hello, {firstName} {lastName}, {age}, {gender}, {salary}, {isActive}");
    }
}