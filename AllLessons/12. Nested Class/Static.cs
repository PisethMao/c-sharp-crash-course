namespace FirstProgram._12._Nested_Class;

public class Static
{
    private static class Inner
    {
        public static void Show()
        {
            Console.WriteLine("This is the Static Inner Class.");
        }
    }
    
    public static void Run()
    {
        Inner.Show();
    }
}