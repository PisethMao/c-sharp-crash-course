namespace FirstProgram._18._Exceptions.Basic_Exception;

public class Finally
{
    public static void Run()
    {
        try
        {
            Console.WriteLine("1. Try Started");
            var a = 10;
            var b = 0;
            Console.WriteLine(a / b);
            Console.WriteLine("2. Try Completed");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("3. Exception Caught");
        }
        finally
        {
            Console.WriteLine("4. Finally Executed");
        }

        Console.WriteLine("5. Program Finished");
    }
}