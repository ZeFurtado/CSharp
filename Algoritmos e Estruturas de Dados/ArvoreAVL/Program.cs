using System.Diagnostics.Contracts;

namespace ArvoreAVL;

public class Program
{
    public static void Main(string[] args)
    {
        ArvoreAVL<string> arvoreAVL = new ArvoreAVL<string>();

        int opcao = 0;

    
        while(opcao != 5)
        {
            Console.WriteLine(" --- ÁRVORE AVL ---");
            Console.WriteLine("(1) Adicionar");
            Console.WriteLine("(2) Remover");
            Console.WriteLine("(3) Procurar");
            Console.WriteLine("(4) Imprimir estado atual da árvore");
            Console.WriteLine("(5) Sair");

            try
            {
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Adicionar");
                        arvoreAVL.Inserir(Console.ReadLine());
                    break;
                    
                    case 2:
                        Console.WriteLine("Digite o número da chave que deseja remover");
                        arvoreAVL.Remover(int.Parse(Console.ReadLine()));
                    break;

                    case 3:
                        Console.WriteLine("Digite um número ou nome para procurar");
                        arvoreAVL.Busca(int.Parse(Console.ReadLine()));
                    break;
                
                    case 4:
                        Console.WriteLine("Estado atual da árvore");
                        arvoreAVL.PrintTree();
                    break;
                
                    case 5:
                        opcao = 5;
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                    break;
            }    
            }catch(System.FormatException ex)
            {
                Console.WriteLine("Digite um número");
                opcao = 0;
            }
            
        }
        
    }
}
