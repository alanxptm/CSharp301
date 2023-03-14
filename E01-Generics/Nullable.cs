namespace E01_Generics;

public class Nullable<T> where T : struct
{
    private object _value;

    public Nullable(T value)
    {
        _value = value;
    }

    public bool HasValue => _value != null;

    public T GetValueOrDefault()
    {
        return HasValue != null ? (T)_value : default(T);
    }
}