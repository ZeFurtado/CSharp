using System.Diagnostics.Contracts;

namespace ArvoreAVL;

public class Program
{
    public static void Main(string[] args)
    {
        ArvoreAVL<string> arvoreAVL = new ArvoreAVL<string>();

        arvoreAVL.Inserir("Jurandir");
        arvoreAVL.Inserir("Moacir");
        arvoreAVL.Inserir("Valtencir");

        arvoreAVL.PrintTree();
        Console.WriteLine($"Menor Chave: {arvoreAVL.MenorChave()}");
    }
}
