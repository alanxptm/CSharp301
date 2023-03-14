namespace E01_Generics;

// constraints
// where T: IComparable
// where T: class
// where T: struct
// where T: new()

public class GenericList<T>
{
    public void Add(T value)
    {
        throw new NotImplementedException();
    }

    public T this[int index] => throw new NotImplementedException();
}