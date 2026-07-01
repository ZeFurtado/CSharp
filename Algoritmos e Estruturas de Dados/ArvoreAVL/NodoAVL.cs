using System.Runtime.CompilerServices;

namespace ArvoreAVL;

public class NodoAVL<T>
{
    public T Item{get;set;}
    public int Chave{get;} //Outras classes só poderão consultar a chave
    public NodoAVL<T>? NodoDireita{get;set;}
    public NodoAVL<T>? NodoEsquerda{get;set;}

    public NodoAVL(T item)
    {
        Item = item;
        Chave = Chave + 1;
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

    public int fatorBalanceamento()
    {
        return altura(NodoEsquerda) - altura(NodoDireita);
    }

    
}
