using System.Collections.Frozen;

namespace FirstProgram._16._Collections_Framework.Frozen;

public class FrozenSet
{
    public static void Run()
    {
        string[] roles = ["ADMIN", "USER", "MANAGER"];
        // FrozenSet<string> frozenSet = roles.ToFrozenSet();
        var frozenSet = roles.ToFrozenSet();
        Console.WriteLine(frozenSet.Count);
        Console.WriteLine(frozenSet.Contains("ADMIN"));
    }
}