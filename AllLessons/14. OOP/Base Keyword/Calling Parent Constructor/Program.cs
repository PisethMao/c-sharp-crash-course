namespace FirstProgram._14._OOP.Base_Keyword.Calling_Parent_Constructor;

public class Program
{
    public static void Run()
    {
        var emp = new Employee("Piseth", 1000);

        Console.WriteLine(emp.Name);
        Console.WriteLine(emp.Salary);
    }
}