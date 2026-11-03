namespace FirstProgram._16._Collections_Framework.Basic_Generic;

public class EnumSet
{
    private enum Status
    {
        Pending,
        Approved,
        Rejected
    }

    public static void Run()
    {
        HashSet<Status> statusSet = [Status.Approved, Status.Rejected, Status.Pending];
        Console.WriteLine(statusSet.Count);
    }
}