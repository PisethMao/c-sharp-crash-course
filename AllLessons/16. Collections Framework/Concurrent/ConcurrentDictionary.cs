using System.Collections.Concurrent;

namespace FirstProgram._16._Collections_Framework.Concurrent;

public class ConcurrentDictionary
{
    public static void Run()
    {
        ConcurrentDictionary<int, string> users = new();
        users.TryAdd(1, "User1");
        users.TryAdd(2, "User2");
        users.TryUpdate(1, "User1", "User2");
        users.AddOrUpdate(2, "Unknown", (_, _) => "Bob");
        Console.WriteLine(users[1]);
        Console.WriteLine(users[2]);
        users.TryRemove(1, out _);
    }
}