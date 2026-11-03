namespace FirstProgram._17._Generic.Generic_Constraints.Struct;

public class NumberStorage<T> where T : struct
{
    public T Value { get; init; }
}