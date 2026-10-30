namespace FirstProgram._14._OOP.Encapsulations.Properties;

public class Student
{
    public string Name
    {
        get;
        init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            field = value;
        }
    } = "";
}