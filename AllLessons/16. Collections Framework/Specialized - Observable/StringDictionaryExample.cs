using System.Collections.Specialized;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class StringDictionaryExample
{
    public static void Run()
    {
        StringDictionary settings = new()
        {
            { "language", "C#" },
            { "theme", "Dark" }
        };
        Console.WriteLine(settings["language"]);
        settings["theme"] = "Light";
        Console.WriteLine(settings["theme"]);
    }
}