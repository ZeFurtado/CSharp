using System.Diagnostics.Contracts;

namespace ArvoreAVL;

public class Program
{
    public static void Main(string[] args)
    {
        ArvoreAVL<string> arvoreAVL = new ArvoreAVL<string>();

        arvoreAVL.Inserir("Jurandir");
        arvoreAVL.PrintTree();


        arvoreAVL.Inserir("Moacir");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Valtencir");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Cláudio");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Cleiton");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Joniver");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Cléber");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Hugo");
        arvoreAVL.PrintTree();

        arvoreAVL.Remover(3);
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Thiago");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Juliano");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Júlio");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Júnior");
        arvoreAVL.PrintTree();

        arvoreAVL.Inserir("Alvares");
        arvoreAVL.Inserir("Ricardinho");
        arvoreAVL.Inserir("Soares");

        arvoreAVL.PrintTree();

        arvoreAVL.Remover(8);
        arvoreAVL.PrintTree();
        Console.WriteLine(arvoreAVL.ToString());
    }
}
