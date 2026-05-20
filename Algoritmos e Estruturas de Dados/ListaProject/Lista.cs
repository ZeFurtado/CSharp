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

    public void RemoveItem(int pos)
    {
        T[] newValues = new T[Values.Length - 1];
        int j = 0;

        for(int i = 0; i < Values.Length; i++)
        {
            if(i != pos)
            {
                newValues[j] = Values[i]; 
                j++;
            }
        }

        Values = newValues;
    }

    public void RemovePrimeiro()
    {
        T[] newValues = new T[Values.Length - 1];
        int j = 0;
        for(int i = 1; i < Values.Length; i++)
        {
            newValues[j] = Values[i];
            j++;
        }

        Values = newValues;
    }

    public void RemoveUltimo()
    {
        T[] newValues = new T[Values.Length - 1];

        for(int i = 0; i < Values.Length - 1; i++)
        {
            newValues[i] = Values[i];
        }

        Values = newValues;
    }

    public void Inverter()
    {
        T[] newValues = new T[Values.Length];
        int j = 0;

        for(int i = Values.Length - 1; i >=0; i--)
        {
            newValues[j] = Values[i];
            j++;
        }

        Values = newValues;
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
