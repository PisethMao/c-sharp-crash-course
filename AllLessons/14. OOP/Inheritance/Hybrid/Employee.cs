namespace FirstProgram._14._OOP.Inheritance.Hybrid;

public class Employee : Person, IWorker
{
    public void Work()
    {
        Console.WriteLine($"{Name} is working...");
    }
}