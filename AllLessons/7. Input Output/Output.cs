namespace FirstProgram._7._Input_Output;

public class Output
{
    public static void Run()
    {
        Console.WriteLine("Hello, C#");
        Console.WriteLine("Welcome to C#");
        
        Console.Write("Hello, ");
        Console.Write("C#");

        const string name = "Piseth Mao";
        const int age = 21;
        const double salary = 370.000;
        
        // Approach 1
        Console.WriteLine("Name is: {0}", name);
        Console.WriteLine("Age is: {0}", age);
        Console.WriteLine("Salary is: {0:F2}", salary);
        // Approach 2
        Console.WriteLine($"Name is: {name}");
        Console.WriteLine($"Age is: {age}");
        Console.WriteLine($"Salary is: {salary:F2}");

        const string firstName = "Piseth";
        const string lastName = "Mao";
        // Using the + Operator
        const string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full name is: {fullName}");
        // Using String Interpolation (Recommended)
        const string fullName2 = $"{firstName} {lastName}";
        Console.WriteLine($"Full name is: {fullName2}");
        // Using string.Concat()
        var fullName3 = string.Concat(firstName, " ",  lastName);
        Console.WriteLine($"Full name is: {fullName3}");
        // Using string.Join()
        string[] names = ["Piseth", "Sophaneth", "Pisal"];
        var result = string.Join(", ", names);
        Console.WriteLine($"Result is: {result}");
    }
}