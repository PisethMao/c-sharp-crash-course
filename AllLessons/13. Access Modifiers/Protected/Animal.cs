namespace FirstProgram._13._Access_Modifiers.Protected;

public class Animal
{
    protected readonly string Name;

    protected Animal(string name)
    {
        Name = name;
    }

    protected static void Eat()
    {
        Console.WriteLine("Animal is Eating...");
    }
}