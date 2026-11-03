using System.ComponentModel;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class BindingListExample
{
    public static void Run()
    {
        BindingList<string> names = [];
        names.ListChanged += (_, e) =>
        {
            Console.WriteLine($"Changed: {e.ListChangedType}");
        };
        names.Add("John");
        names.Add("Jane");
        names.RemoveAt(0);
    }
}