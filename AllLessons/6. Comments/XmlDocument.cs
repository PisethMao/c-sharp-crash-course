namespace FirstProgram._6._Comments;

/// <summary>
/// Provides mathematical operations.
/// </summary>
public class XmlDocument
{
    /// <summary>
    /// Adds two integer numbers.
    /// </summary>
    /// <param name="a">First number.</param>
    /// <param name="b">Second number.</param>
    /// <returns>The sum of two numbers.</returns>
    private static int Add(int a, int b)
    {
        return a + b;
    }

    public static void Run()
    {
        Console.WriteLine(Add(1, 2));
    }
}