using System.Collections.ObjectModel;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class ObservableCollection
{
    public static void Run()
    {
        ObservableCollection<string> products = [];
        products.CollectionChanged += (_, args) =>
        {
            Console.WriteLine($"Action: {args.Action}");
        };
        products.Add("Windows");
        products.Add("Apple");
        products.Remove("Windows");
    }
}