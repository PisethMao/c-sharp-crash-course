namespace FirstProgram._11._Class_Object.This;

public class Students
{
    private string name;

    public Students() : this("Unknown")
    {
    }

    public Students(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
    }
}