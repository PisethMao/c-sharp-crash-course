namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Indexers;

public class DefaultIndexerDemo
{
    public static void Run()
    {
        IStudentCollection collection = new StudentCollection();
        Console.WriteLine(collection.Students.Length);
        Console.WriteLine(collection[0]);
        Console.WriteLine(collection[1]);
        Console.WriteLine(collection[2]);
    }
}