namespace ArvoreAVL;

public class ArvoreAVL<T>
{
    private NodoAVL<T> NodoRaiz;

    public ArvoreAVL()
    {
        
    }

    public void Inserir(NodoAVL<T> item)
    {
        InserirRecursivo(item);
    }

    private void InserirRecursivo(NodoAVL<T> item)
    {
        if (NodoRaiz == null)
        {
            NodoRaiz = item;
        }else
        {
            item.NodoDireita = item;
        }
    }
}
