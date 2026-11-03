using System.Collections.ObjectModel;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable.Key_Collection;

public class StudentCollection : KeyedCollection<int, Student>
{
    protected override int GetKeyForItem(Student item)
    {
        return item.Id;
    }
}