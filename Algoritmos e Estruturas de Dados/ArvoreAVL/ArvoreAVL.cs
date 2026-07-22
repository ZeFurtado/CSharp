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

    private NodoAVL<T> InserirRecursivo(NodoAVL<T> nodoAVL, T item, int chave)
    {
        chave++;
        if(nodoAVL == null)
        {
            return new NodoAVL<T>(item, chave);
        }else
        {
            nodoAVL.setNodoDireita(InserirRecursivo(nodoAVL.NodoDireita, item, nodoAVL.Chave));
        }

        if(nodoAVL.FatorBalanceamento() <-1 && nodoAVL.NodoDireita.FatorBalanceamento() <= 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação simples para á esquerda");
            return this.RotacaoSimplesEsquerda(nodoAVL);
        }else if(nodoAVL.FatorBalanceamento() > 1 && nodoAVL.NodoEsquerda.FatorBalanceamento() >= 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação simples para á direita");
            return this.RotacaoSimplesDireita(nodoAVL);
        }else if(nodoAVL.FatorBalanceamento() <-1 && nodoAVL.NodoDireita.FatorBalanceamento() > 0)
        {
            Console.WriteLine($"O nodo de chave {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação dupla á esquerda");
            nodoAVL.setNodoDireita(this.RotacaoSimplesDireita(nodoAVL.NodoDireita));
            return this.RotacaoSimplesEsquerda(nodoAVL);
        }else if(nodoAVL.FatorBalanceamento() > 1 && nodoAVL.NodoEsquerda.FatorBalanceamento() < 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação dupla a direita");
            nodoAVL.setNodoEsquerda(this.RotacaoSimplesEsquerda(nodoAVL.NodoEsquerda));
            return this.RotacaoSimplesDireita(nodoAVL);
        }

        return nodoAVL;
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

                //Caso o nodo removido possua filhos o substituto dele será o menor nodo á direita dele
                NodoAVL<T> newNode = Busca(MenorChave(nodoAVL.NodoDireita));
                nodoAVL.Chave = newNode.Chave;
                nodoAVL.Item = newNode.Item;
                nodoAVL.setNodoDireita(RemoverRecursivo(nodoAVL.NodoDireita, nodoAVL.Chave));
            }

            if(nodoAVL.FatorBalanceamento() <-1 && nodoAVL.NodoDireita.FatorBalanceamento() <= 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação simples para á esquerda");
            return this.RotacaoSimplesEsquerda(nodoAVL);
        }else if(nodoAVL.FatorBalanceamento() > 1 && nodoAVL.NodoEsquerda.FatorBalanceamento() >= 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação simples para á direita");
            return this.RotacaoSimplesDireita(nodoAVL);
        }else if(nodoAVL.FatorBalanceamento() <-1 && nodoAVL.NodoDireita.FatorBalanceamento() > 0)
        {
            Console.WriteLine($"O nodo de chave {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação dupla á esquerda");
            nodoAVL.setNodoDireita(this.RotacaoSimplesDireita(nodoAVL.NodoDireita));
            return this.RotacaoSimplesEsquerda(nodoAVL);
        }else if(nodoAVL.FatorBalanceamento() > 1 && nodoAVL.NodoEsquerda.FatorBalanceamento() < 0)
        {
            Console.WriteLine($"O nodo de chave: {nodoAVL.Chave} está desbalanceado");
            Console.WriteLine("Rotação dupla a direita");
            nodoAVL.setNodoEsquerda(this.RotacaoSimplesEsquerda(nodoAVL.NodoEsquerda));
            return this.RotacaoSimplesDireita(nodoAVL);
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
    
    private int MenorChave(NodoAVL<T> nodoAVL)
    {
        int chave;
        for(chave = nodoAVL.Chave; nodoAVL.NodoEsquerda != null; nodoAVL = nodoAVL.NodoEsquerda)
        {
            chave = nodoAVL.NodoEsquerda.Chave;
        }

        return chave;
    }
    

    public void PrintTree()
    {
        Console.WriteLine("\n--- Estrutura atual da Árvore AVL ---");
        this.PrintTreeHelper(this.NodoRaiz, 0);
        Console.WriteLine("---------------------------------------");
    }

    private void PrintTreeHelper(NodoAVL<T> nodoAVL, int espaco)
    {
        int count = 8;
        if(nodoAVL != null)
        {
            espaco += count;
            this.PrintTreeHelper(nodoAVL.NodoDireita, espaco);
            Console.WriteLine();

            for(int i = count; i < espaco; i++)
            {
                Console.Write(" ");
            }

            int fb = nodoAVL.FatorBalanceamento();
            Console.WriteLine($"({nodoAVL.Chave})[{nodoAVL.Item}] Fb={fb}");
            this.PrintTreeHelper(nodoAVL.NodoEsquerda, espaco);
        }
    }

    private NodoAVL<T> RotacaoSimplesEsquerda(NodoAVL<T> nodoAVL)
    {
        NodoAVL<T> nodoDireita = nodoAVL.NodoDireita;
        NodoAVL<T> nodoEsquerda = nodoDireita.NodoEsquerda;
        nodoDireita.setNodoEsquerda(nodoAVL);
        nodoAVL.setNodoDireita(nodoEsquerda);
        return nodoDireita; 
    }

    private NodoAVL<T> RotacaoSimplesDireita(NodoAVL<T> nodoAVL)
    {
        NodoAVL<T> nodoEsquerda = nodoAVL.NodoEsquerda;
        NodoAVL<T> nodoDireita = nodoEsquerda.NodoDireita;
        nodoEsquerda.setNodoDireita(nodoAVL);
        nodoAVL.setNodoEsquerda(nodoDireita);
        return nodoEsquerda;
    }

}
