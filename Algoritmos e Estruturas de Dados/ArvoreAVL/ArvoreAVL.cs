namespace ArvoreAVL;

public class ArvoreAVL<T>
{
    private NodoAVL<T> NodoRaiz;
    public int UltimaChave{get;private set;} 
    
    public ArvoreAVL()
    {
        
    }

    public void Inserir(T item)
    {
        int chave = -1;
        this.NodoRaiz = InserirRecursivo(this.NodoRaiz, item, chave);
    }

    private NodoAVL<T> InserirRecursivo(NodoAVL<T> nodoRaiz, T item, int chave)
    {
        chave++;
        if(nodoRaiz == null)
        {
            return new NodoAVL<T>(item, chave);
        }else
        {
            nodoRaiz.setNodoDireita(InserirRecursivo(nodoRaiz.NodoDireita, item, chave));
        }

        return nodoRaiz;
    }

    public NodoAVL<T> Busca(int chave)
    {
        return BuscaRecorsiva(this.NodoRaiz, chave);
    }

    private NodoAVL<T> BuscaRecorsiva(NodoAVL<T> nodoAVL, int chave)
    {
        //Verifica se o nodo não é vazio e se a chave do nodoAtual não é a mesma da chave a ser buscada;
        if(nodoAVL != null && nodoAVL.Chave != chave)
        {
            return chave > nodoAVL.Chave ? BuscaRecorsiva(nodoAVL.NodoDireita, chave) : BuscaRecorsiva(nodoAVL.NodoEsquerda, chave);
        }else
        {
            if(nodoAVL != null) Console.WriteLine($"Nodo encontrado: {nodoAVL.Item}");
            return nodoAVL;
        }
    }    
    
    private int MenorChave(NodoAVL<T> nodoRaiz)
    {
        int chave;
        for(chave = nodoRaiz.Chave; nodoRaiz.NodoEsquerda != null; nodoRaiz = nodoRaiz.NodoEsquerda)
        {
            chave = nodoRaiz.NodoEsquerda.Chave;
        }

        return chave;
    }
    

    public void PrintTree()
    {
        Console.WriteLine("\n--- Estrutura atual da Árvore AVL ---");
        this.PrintTreeHelper(this.NodoRaiz, 0);
        Console.WriteLine("---------------------------------------");
    }

    private void PrintTreeHelper(NodoAVL<T> nodoAtual, int espaco)
    {
        int count = 8;
        if(nodoAtual != null)
        {
            espaco += count;
            this.PrintTreeHelper(nodoAtual.NodoDireita, espaco);
            Console.WriteLine();

            for(int i = count; i < espaco; i++)
            {
                Console.Write(" ");
            }

            int fb = nodoAtual.fatorBalanceamento();
            Console.WriteLine($"({nodoAtual.Chave})[{nodoAtual.Item}] Fb={fb}");
            this.PrintTreeHelper(nodoAtual.NodoEsquerda, espaco);
        }
    }

}
