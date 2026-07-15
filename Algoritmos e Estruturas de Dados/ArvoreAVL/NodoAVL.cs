using System.Runtime.CompilerServices;

namespace ArvoreAVL;

public class NodoAVL<T>
{
    public T Item{get;set;}
    public int Chave {get; set;}
    public NodoAVL<T>? NodoDireita{get; private set;}
    public NodoAVL<T>? NodoEsquerda{get; private set;}

    public NodoAVL(T item, int chave)
    {
        Item = item;
        Chave = chave;
        NodoDireita = null;
        NodoEsquerda = null;
    }


    public int altura(NodoAVL<T> raiz)
    {
        if(raiz == null)
        {
            return 0;
        }else
        {
            int alturaDireita = altura(raiz.NodoDireita);
            int alturaEsquerda = altura(raiz.NodoEsquerda);

            return Math.Max(alturaDireita, alturaEsquerda) + 1;
        }
         
    }

    public int FatorBalanceamento()
    {
        return altura(NodoEsquerda) - altura(NodoDireita);
    }

    public void setNodoDireita(NodoAVL<T> nodoAVL)
    {
        NodoDireita = nodoAVL;
    }

    public void setNodoEsquerda(NodoAVL<T> nodoAVL)
    {
        NodoEsquerda = nodoAVL;
    }

    
}
