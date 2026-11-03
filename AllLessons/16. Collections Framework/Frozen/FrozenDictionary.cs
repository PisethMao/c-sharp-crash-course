using System.Collections.Frozen;

namespace FirstProgram._16._Collections_Framework.Frozen;

public class FrozenDictionary
{
    public static void Run()
    {
        Dictionary<int, string> source = new()
        {
            [1] = "Pending",
            [2] = "Rejected",
            [3] = "Approved"
        };
        // FrozenDictionary<int, string> statuses = source.ToFrozenDictionary();
        var statuses = source.ToFrozenDictionary();
        Console.WriteLine(statuses[2]);
        Console.WriteLine(statuses.ContainsKey(2));
    }
}