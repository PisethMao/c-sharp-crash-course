namespace FirstProgram._14._OOP.Encapsulations.Private_Fields_Public_Method;

public class Student
{
    private string _name = "";

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty");
        }
        _name = name;
    }
    
    public string GetName()
    {
        return _name;
    }
}