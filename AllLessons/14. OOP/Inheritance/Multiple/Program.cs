namespace FirstProgram._14._OOP.Inheritance.Multiple;

public class Program
{
    public static void Run()
    {
        IPrinter printer = new Machine();
        printer.Print();
        IScanner scanner = new Machine();
        scanner.Scan();
    }
}