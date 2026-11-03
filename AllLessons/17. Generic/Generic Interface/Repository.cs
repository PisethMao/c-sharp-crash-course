namespace FirstProgram._17._Generic.Generic_Interface;

public class Repository<T> : IRepository<T>
{
    private readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return _items;
    }
}