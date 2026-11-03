namespace FirstProgram._17._Generic.Generic_Constraints.New;

public class Factory<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}