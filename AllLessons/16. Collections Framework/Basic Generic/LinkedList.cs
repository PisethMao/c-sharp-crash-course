namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class LinkedList
{
    public static void Run()
    {
        LinkedList<string> names = new();
        names.AddLast("Peter");
        names.AddLast("Michael");
        names.AddLast("James");
        var node = names.Find("James");
        if (node != null)
        {
            names.AddAfter(node, "Bob");
        }

        names.Remove("James");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}