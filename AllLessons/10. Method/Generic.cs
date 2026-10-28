namespace FirstProgram._10._Method.Generic;

public class Generic
{
    public T GetValue<T>(T defaultValue)
    {
        return defaultValue;
    }
    
    public static void Run()
    {
        Generic generic = new Generic();
        int age = generic.GetValue(17);
        string name = generic.GetValue("Piseth");
        bool isMale = generic.GetValue(true);
        Console.WriteLine(age);
        Console.WriteLine(name);
        Console.WriteLine(isMale);
    }
}