using System.Collections.Specialized;

namespace FirstProgram._16._Collections_Framework.Specialized___Observable;

public class NameValueCollectionExample
{
    public static void Run()
    {
        NameValueCollection settings = new()
        {
            { "Language", "English" },
            { "Language", "Spanish" },
            { "Language", "Khmer" }
        };
        var languages = settings.GetValues("Language");
        if (languages == null)
        {
            return;
        }
        foreach (var language in languages)
        {
            Console.WriteLine(language);
        }
    }
}