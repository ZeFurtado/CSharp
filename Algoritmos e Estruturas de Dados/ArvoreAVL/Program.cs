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
    }
}
