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
    public void AddItem(T item)
    {
        T[] NewValues = new T[Values.Length + 1];
        int index = 0;
        foreach(T t in Values)
        {
            NewValues[index] = t;
            index++;
        }

        NewValues[Values.Length] = item;
        Values = NewValues;
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
