namespace FirstProgram._11._Class_Object.Constructor.overloading;

public class Overloading(string name = "Default", int age = 0)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public Overloading() : this("Default", 0)
    {
    }

    public Overloading(string name) : this(name, 0)
    {
    }
}