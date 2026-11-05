namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Properties;

public class DefaultPropertyDemo
{
    public static void Run()
    {
        IEmployee employee = new Employee() { MonthlySalary = 100m };
        Console.WriteLine($"Monthly Salary is: {employee.MonthlySalary}");
        Console.WriteLine($"Annual Salary is: {employee.AnnualSalary}");
    }
}