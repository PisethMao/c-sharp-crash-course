namespace FirstProgram._10._Method;

public class Void
{
    public void SayHello()
    {
        Console.WriteLine("Hello World!");
    }
    
    public static void Run()
    {
        Void v = new Void();
        v.SayHello();
    }
}