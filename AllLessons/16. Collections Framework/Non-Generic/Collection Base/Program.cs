namespace FirstProgram._16._Collections_Framework.Non_Generic.Collection_Base;

public class Program
{
    public static void Run()
    {
        StudentNames studentNames = ["John Doe", "Alice"];
        Console.WriteLine(studentNames.ToString());
        Console.WriteLine(studentNames.Get(0));
    }
}