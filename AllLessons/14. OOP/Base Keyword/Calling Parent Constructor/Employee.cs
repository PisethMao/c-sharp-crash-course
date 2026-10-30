namespace FirstProgram._14._OOP.Base_Keyword.Calling_Parent_Constructor;

public class Employee : Person
{
    public int Salary { get; }
    
    public Employee(string name,  int salary)
        : base(name)
    {
        Salary = salary;
        Console.WriteLine($"Employee Constructor called");
    }
}