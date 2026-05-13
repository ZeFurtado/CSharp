namespace ListaProject;

public class BaseGenerics<T>
{
    private readonly T _item;

    public BaseGenerics(T item)
    {
        _item = item;
    }

    public T GetItem()
    {
        return _item;
    }
}
