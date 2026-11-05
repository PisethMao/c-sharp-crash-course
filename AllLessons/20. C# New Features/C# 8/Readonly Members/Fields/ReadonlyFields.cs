namespace FirstProgram._20._C__New_Features.C__8.Readonly_Members.Fields;

public class ReadonlyFields(int id, string name)
{
    private void Display()
    {
        Console.WriteLine($"ID: {id}, Name: {name}");
    }

    public static void Run()
    {
        ReadonlyFields readonlyFields = new(1001, "Piseth Mao");
        readonlyFields.Display();
    }
}