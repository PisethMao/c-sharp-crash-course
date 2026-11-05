namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Indexers;

public interface IStudentCollection
{
    string[] Students { get; }

    string this[int index] => Students[index];
}