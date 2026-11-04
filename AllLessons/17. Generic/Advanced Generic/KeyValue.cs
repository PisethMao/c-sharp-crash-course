namespace FirstProgram._17._Generic.Advanced_Generic;

public class KeyValue<TKey,TValue>(TKey key, TValue value)
{
    public TKey Key { get; } = key;
    public TValue Value { get; } = value;
}