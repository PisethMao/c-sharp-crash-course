namespace FirstProgram._11._Class_Object.Base;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }

    public override void Speak()
    {
        base.Speak();
        Console.WriteLine("Dog is speaking right now.");
    }
}