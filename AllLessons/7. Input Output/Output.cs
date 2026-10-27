namespace FirstProgram._7._Input_Output;

public class Output
{
    public static void Run()
    {
        Console.WriteLine("Hello, C#");
        Console.WriteLine("Welcome to C#");
        
        Console.Write("Hello, ");
        Console.Write("C#");

        string name = "Piseth Mao";
        int age = 21;
        double salary = 370.000;
        
        // Approach 1
        Console.WriteLine("Name is: {0}", name);
        Console.WriteLine("Age is: {0}", age);
        Console.WriteLine("Salary is: {0:F2}", salary);
        // Approach 2
        Console.WriteLine($"Name is: {name}");
        Console.WriteLine($"Age is: {age}");
        Console.WriteLine($"Salary is: {salary:F2}");

        string firstName = "Piseth";
        string lastName = "Mao";
        // Using the + Operator
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full name is: {fullName}");
        // Using String Interpolation (Recommended)
        string fullName2 = $"{firstName} {lastName}";
        Console.WriteLine($"Full name is: {fullName2}");
        // Using string.Concat()
        string fullName3 = string.Concat(firstName, " ",  lastName);
        Console.WriteLine($"Full name is: {fullName3}");
        // Using string.Join()
        string[] names = ["Piseth", "Sophaneth", "Pisal"];
        string result = string.Join(", ", names);
        Console.WriteLine($"Result is: {result}");
    }
}