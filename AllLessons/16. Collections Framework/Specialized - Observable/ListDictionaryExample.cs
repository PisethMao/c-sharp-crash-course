using System.Collections.Specialized;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class ListDictionaryExample
{
    public static void Run()
    {
        ListDictionary settings = new()
        {
            { "Host", "Localhost" },
            { "Port", 8008 }
        };
        Console.WriteLine(settings["Host"]);
        settings.Remove("Port");
        Console.WriteLine(settings.Count);
    }
}