namespace FirstProgram._7._Input_Output;

public class Input
{
    public static void Run()
    {
        Console.Write("Enter the first name: ");
        // string firstName = Console.ReadLine();
        // string? firstName = Console.ReadLine();
        var firstName = Console.ReadLine() ?? "";
        Console.Write("Enter the last name: ");
        var lastName = Console.ReadLine();
        Console.Write("Enter the age: ");
        // string? age = Console.ReadLine();
        // int age = int.Parse(Console.ReadLine());
        // int age = int.Parse(Console.ReadLine()!);
        Console.WriteLine(
            int.TryParse(Console.ReadLine(), out var age)
                ? $"Your age is: {age}"
                : "Invalid input!"
        );
        Console.Write("Enter the gender: ");
        var gender = Console.ReadLine();
        Console.Write("Enter the salary: ");
        var salary = decimal.Parse(Console.ReadLine()!);
        Console.Write("Are you active (true/false)? ");
        var isActive = bool.Parse(Console.ReadLine()!);

        Console.WriteLine($"Hello, {firstName} {lastName}, {age}, {gender}, {salary}, {isActive}");
    }
}