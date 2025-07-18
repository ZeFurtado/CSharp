using System.IO;

namespace LerArquivo;

public class Program
{
    static void Main(string[] args)
    {
        string texto = File.ReadAllText("/home/lukhas/Documentos/texto.txt");

        Console.WriteLine(texto);

        string[] linhas = File.ReadAllLines("/home/lukhas/Documentos/texto.txt");

        foreach (string n in linhas)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Quantidade de linhas: " + linhas.Length); 
        Console.ReadKey();
    }

    
}
