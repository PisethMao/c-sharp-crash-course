namespace FirstProgram._11._Class_Object.This;

public class Students(string name)
{
    public Students() : this("Unknown")
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
    }
}