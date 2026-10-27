namespace FirstProgram._5._Operators;

public class Assignment
{
    public static void Run()
    {
        int number = 10;

        number += 5;
        Console.WriteLine(number);

        number -= 3;
        Console.WriteLine(number);
        
        number *= 2;
        Console.WriteLine(number);
        
        number /= 4;
        Console.WriteLine(number);

        number %= 4;
        Console.WriteLine(number);
    }
}