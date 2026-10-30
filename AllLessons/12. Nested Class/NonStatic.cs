namespace FirstProgram._12._Nested_Class;

public class NonStatic
{
    private static class Inner
    {
        public static void Show()
        {
            Console.WriteLine("This is Non-Static Inner Class.");
        }
    }

    public static void Run()
    {
        Inner.Show();
    }
}