namespace FirstProgram._14._OOP.Base_Keyword.Calling_Parent_Constructor;

public class Person
{
    public string Name { get; }

    protected Person(string name)
    {
        Name = name;
        Console.WriteLine("Person Constructor");
    }
}