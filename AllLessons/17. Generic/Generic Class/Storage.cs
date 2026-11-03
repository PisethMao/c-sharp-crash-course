namespace FirstProgram._17._Generic.Generic_Class;

public class Storage<T>(T value)
{
    private T _value = value;

    public void SetDefault(T value)
    {
        _value = value;
    }

    public T GetDefault()
    {
        return _value;
    }
}