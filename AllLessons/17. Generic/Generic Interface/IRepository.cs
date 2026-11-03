namespace FirstProgram._17._Generic.Generic_Interface;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
}