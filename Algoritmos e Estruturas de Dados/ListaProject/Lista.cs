namespace ListaProject;

public class Lista<T>
{
    private object Tipo {get;set;}
    private T[] Values {get;set;}

    public Lista(T item)
    {
        Tipo = item.GetType();
        Values = new T[]{item};
    }
    

    public T GetItem(int pos)
    {
        return Values[pos];
    }

    public T[] GetValues()
    {
        return Values;
    }

    public object GetTipo()
    {
        return Tipo;
    }

}
