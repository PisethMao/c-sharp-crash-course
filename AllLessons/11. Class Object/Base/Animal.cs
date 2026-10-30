namespace FirstProgram._11._Class_Object.Base;

public class Animal
{
    protected Animal(string name)
    {
        Console.WriteLine(name);
    }

    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking right now.");
    }
}