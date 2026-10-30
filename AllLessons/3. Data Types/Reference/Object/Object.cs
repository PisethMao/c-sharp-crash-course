namespace FirstProgram._3._Data_Types.Reference.Object;

public class Object
{
    public static void Run()
    {
        object name = "John Doe";
        object age = 30;
        object salary = 50000.0;
        object isActive = true;

        Console.WriteLine($"Name is: {name}");
        Console.WriteLine($"Age is: {age}");
        Console.WriteLine($"Salary is: {salary}");
        Console.WriteLine($"Is Active is: {isActive}");
    }
}