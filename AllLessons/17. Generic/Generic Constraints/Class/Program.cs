namespace FirstProgram._17._Generic.Generic_Constraints.Class;

public class Program
{
    public static void Run()
    {
        var repository = new Repository<string>();
        repository.Save("Hello World");
    }
}