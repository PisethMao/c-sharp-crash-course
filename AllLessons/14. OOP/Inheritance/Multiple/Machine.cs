namespace FirstProgram._14._OOP.Inheritance.Multiple;

public class Machine : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Machine printed");
    }

    public void Scan()
    {
        Console.WriteLine("Machine scanner printed");
    }
}