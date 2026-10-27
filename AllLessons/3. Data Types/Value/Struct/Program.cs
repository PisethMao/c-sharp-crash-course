namespace FirstProgram._3._Data_Types.Value.Struct;

public class Program
{
    public static void Run()
    {
        Struct s = new() { X = 0, Y = 0 };
        Struct s2 = s;
        s2.X = 1;
        
        Console.WriteLine(s.X);
        Console.WriteLine(s2.X);
        Console.WriteLine(s.Y);
        Console.WriteLine(s2.Y);
    }
}