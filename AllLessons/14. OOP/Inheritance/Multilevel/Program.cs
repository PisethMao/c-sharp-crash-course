namespace FirstProgram._14._OOP.Inheritance.Multilevel;

public class Program
{
    public static void Run()
    {
        Animal.Eat();
        Console.WriteLine("----------");
        Dog.Eat();
        Dog.Bark();
        Console.WriteLine("----------");
        Puppy.Eat();
        Puppy.Play();
    }
}