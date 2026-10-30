namespace FirstProgram._14._OOP.Polymorphism.Runtime;

public class Program
{
    public static void Run()
    {
        Animal a1 = new Dog();
        Animal a2 = new Cat();

        a1.Speak();
        a2.Speak();
    }
}