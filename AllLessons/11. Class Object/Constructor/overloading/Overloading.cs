namespace FirstProgram._11._Class_Object.Constructor.overloading;

public class Overloading
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Overloading()
    {
        Name = "Default";
        Age = 0;
    }

    public Overloading(string name)
    {
        Name = name;
        Age = 0;
    }

    public Overloading(string name, int age)
    {
        Name = name;
        Age = age;
    }
}