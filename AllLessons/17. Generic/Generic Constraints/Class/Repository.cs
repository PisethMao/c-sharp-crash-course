namespace FirstProgram._17._Generic.Generic_Constraints.Class;

public class Repository<T> where T : class
{
    public void Save(T entity)
    {
        Console.WriteLine($"Saving {entity}");
    }
}