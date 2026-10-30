namespace FirstProgram._14._OOP.Base_Keyword;

public class Child : Parent
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"{GetType().Name}");
    }
}