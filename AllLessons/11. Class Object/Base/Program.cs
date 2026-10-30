namespace FirstProgram._11._Class_Object.Base;

public class Program
{
    public static void Run()
    {
        var dog = new Dog("Dog");
        dog.Speak();
        Console.WriteLine(dog);
    }
}