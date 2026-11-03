using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic.Dictionary_Base;

public class StudentMap : DictionaryBase
{
    public void Add(int id, string name)
    {
        Dictionary.Add(id, name);
    }

    public string Get(int id)
    {
        return Dictionary[id] as string ?? throw new
            KeyNotFoundException($"Student with ID {id} was not found.");
    }
}