namespace FirstProgram._13._Access_Modifiers.Protected;

public class Dog() : Animal("Dog")
{
    public void Display()
    {
        Console.WriteLine(Name);
        Eat();
    }
}