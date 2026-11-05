namespace FirstProgram._20._C__New_Features.C__8.Positional_Patterns.Class;

public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void Deconstruct(out string name, out int age) => 
        (name, age) = (Name, Age);
}