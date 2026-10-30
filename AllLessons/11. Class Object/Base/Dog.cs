namespace FirstProgram._11._Class_Object.Base;

public class Dog(string name) : Animal(name)
{
    public override void Speak()
    {
        base.Speak();
        Console.WriteLine("Dog is speaking right now.");
    }
}