namespace FirstProgram._17._Generic.Generic_Struct;

public readonly struct Pair<TFirst, TSecond>(TFirst first, TSecond second)
{
    public TFirst First { get; } = first;
    public TSecond Second { get; } = second;
}