namespace FirstProgram._2._Variables;

public class Dynamic
{
    public static void Run()
    {
        dynamic name = "John";
        // Can use all of this
        // name = 10; 
        // name = true;
        // name = 10.0;
        
        Console.WriteLine($"Name: {name}");
    }
}