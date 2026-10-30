namespace FirstProgram._14._OOP.Method_Overriding;

public class Program
{
    public static void Run()
    {
        var animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.Sound();
        dog.Sound();
        cat.Sound();
    }
}