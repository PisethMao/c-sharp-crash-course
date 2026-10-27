namespace FirstProgram._5._Operators;

public class Logical
{
    public static void Run()
    {
        int age = 25;
        bool hasId = true;
        
        Console.WriteLine(age >= 18 && hasId);
        Console.WriteLine(age < 18 || hasId);
        Console.WriteLine(!hasId);
    }
}