using System.IO;

namespace Biblioteca.Arquivo;

public class GerenciadorArquivo
{
    public static void GravarArquivo(string nomeArquivo, string texto)
    {
        string caminho = $"/home/lukhas/repo/CSharp/Projeto/{nomeArquivo}.txt";
        try
        {
            if (File.Exists(caminho))
            {
                throw new IOException();
            }
            else
            {
                using (StreamWriter arquivo = new StreamWriter(caminho))
                {
                    arquivo.WriteLine(texto);
                    Console.WriteLine($"O arquivo '{nomeArquivo}' foi criado com sucesso!!");
                    arquivo.Close();
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine($"Já existe um arquivo com nome: {nomeArquivo}" +
                               "\n O texto será adicionado ao conteúdo já existente no arquivo");
            using (StreamWriter arquivo = File.AppendText(caminho))
            {
                arquivo.WriteLine(texto);
                Console.WriteLine($"O arquivo '{nomeArquivo}' foi adicionado com sucesso!");
                arquivo.Close();
            }
        }
    }

    public static string[] LerArquivo(string nomeArquivo)
    {
        string caminho = $"/home/lukhas/repo/CSharp/Projeto/{nomeArquivo}.txt";

        if (!File.Exists(caminho)) throw new IOException();

        try
        {
            return File.ReadAllLines(caminho);
        }
        catch (IOException)
        {
            Console.WriteLine("O arquivo não existe!!!"); 
            return ["Arquivo não existe"]; 
        }

        
    }
}