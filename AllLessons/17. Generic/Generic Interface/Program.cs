namespace FirstProgram._17._Generic.Generic_Interface;

public class Program
{
    public static void Run()
    {
        var names = new Repository<string>();
        names.Add("John");
        names.Add("Jane");
        foreach (var name in names.GetAll())
        {
            Console.WriteLine(name);
        }

        var numbers = new Repository<int>();
        numbers.Add(1);
        numbers.Add(2);
        foreach (var number in numbers.GetAll())
        {
            Console.WriteLine(number);
        }
    }
}