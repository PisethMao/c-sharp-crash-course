using System.Collections;

namespace FirstProgram._16._Collections_Framework.Non_Generic.Collection_Base;

public class StudentNames : CollectionBase
{
    public void Add(string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        List.Add(name);
    }

    public string Get(int index)
    {
        return List[index] as string ?? throw new
            InvalidOperationException("Student name is null or invalid.");
    }
}