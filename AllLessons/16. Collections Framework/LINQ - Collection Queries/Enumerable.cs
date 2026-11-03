namespace FirstProgram._16._Collections_Framework.LINQ___Collection_Queries;

public class Enumerable
{
    public static void Run()
    {
        List<int> numbers = [1, 2, 3, 4, 5];
        var filteredNumbers = numbers.Where(n => n % 2 == 0);
        var doubledNumbers = filteredNumbers.Select(n => n * 2);
        var results = doubledNumbers.OrderByDescending(n => n);
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}