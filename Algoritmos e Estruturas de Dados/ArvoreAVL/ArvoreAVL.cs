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
            nodoRaiz.setNodoDireita(InserirRecursivo(nodoRaiz.NodoDireita, item, nodoRaiz.Chave));
        }

        if(nodoRaiz.FatorBalanceamento() <-1 && nodoRaiz.NodoDireita.FatorBalanceamento() <= 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoRaiz.Chave} está desbalanceado");
            Console.WriteLine("Rotação simples para á esquerda");
            return this.RotacaoSimplesEsquerda(nodoRaiz);
        }else if(nodoRaiz.FatorBalanceamento() > 1 && nodoRaiz.NodoEsquerda.FatorBalanceamento() >= 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoRaiz.Chave} está desbalanceado");
            Console.WriteLine("Rotação simples para á direita");
            return this.RotacaoSimplesDireita(nodoRaiz);
        }else if(nodoRaiz.FatorBalanceamento() <-1 && nodoRaiz.NodoDireita.FatorBalanceamento() > 0)
        {
            Console.WriteLine($"O nodo de chave {nodoRaiz.Chave} está desbalanceado");
            Console.WriteLine("Rotação dupla á esquerda");
            nodoRaiz.setNodoDireita(this.RotacaoSimplesDireita(nodoRaiz.NodoDireita));
            return this.RotacaoSimplesEsquerda(nodoRaiz);
        }else if(nodoRaiz.FatorBalanceamento() > 1 && nodoRaiz.NodoEsquerda.FatorBalanceamento() < 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoRaiz.Chave} está desbalanceado");
            Console.WriteLine("Rotação dupla a direita");
            nodoRaiz.setNodoEsquerda(this.RotacaoSimplesEsquerda(nodoRaiz.NodoEsquerda));
            return this.RotacaoSimplesDireita(nodoRaiz);
        }

        return nodoRaiz;
    }

    public void Remover(int chave)
    {
        this.RemoverRecursivo(this.NodoRaiz, chave);
    }
    
    private NodoAVL<T> RemoverRecursivo(NodoAVL<T> nodoAVL, int chave)
    {
        if(nodoAVL == null)
        {
            return null;
        }else
        {
            if(chave < nodoAVL.Chave)
            {
                nodoAVL.setNodoEsquerda(RemoverRecursivo(nodoAVL.NodoEsquerda, chave));
            }else if(chave > nodoAVL.Chave)
            {
                nodoAVL.setNodoDireita(RemoverRecursivo(nodoAVL.NodoDireita, chave));
            }else
            {
                if(nodoAVL.NodoEsquerda == null) return nodoAVL.NodoDireita;
                if(nodoAVL.NodoDireita == null) return nodoAVL.NodoEsquerda;

                //Caso o nodo removido possua filhos o substituto dele será o menor nodo á direita dele;
                nodoAVL = Busca(MenorChave(nodoAVL.NodoDireita));
                nodoAVL.setNodoDireita(RemoverRecursivo(nodoAVL.NodoDireita, nodoAVL.Chave));
            }

            return nodoAVL;
        }
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

            int fb = nodoAtual.FatorBalanceamento();
            Console.WriteLine($"({nodoAtual.Chave})[{nodoAtual.Item}] Fb={fb}");
            this.PrintTreeHelper(nodoAtual.NodoEsquerda, espaco);
        }
    }

    private NodoAVL<T> RotacaoSimplesEsquerda(NodoAVL<T> nodoRaiz)
    {
        NodoAVL<T> nodoDireita = nodoRaiz.NodoDireita;
        NodoAVL<T> nodoEsquerda = nodoDireita.NodoEsquerda;
        nodoDireita.setNodoEsquerda(nodoRaiz);
        nodoRaiz.setNodoDireita(nodoEsquerda);
        return nodoDireita; 
    }

    private NodoAVL<T> RotacaoSimplesDireita(NodoAVL<T> nodoRaiz)
    {
        NodoAVL<T> nodoEsquerda = nodoRaiz.NodoEsquerda;
        NodoAVL<T> nodoDireita = nodoEsquerda.NodoDireita;
        nodoEsquerda.setNodoDireita(nodoRaiz);
        nodoRaiz.setNodoEsquerda(nodoDireita);
        return nodoEsquerda;
    }

}
