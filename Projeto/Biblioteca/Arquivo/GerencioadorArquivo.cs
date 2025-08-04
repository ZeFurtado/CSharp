using System.IO;

namespace Biblioteca.Arquivo;

public class GerenciadorArquivo
{
    public void GravarArquivo(string nomeArquivo, string texto)
    {
        try
        {
            string caminho = $"/home/lukhas/repo/CSharp/Projeto/{nomeArquivo}.txt";

            if (File.Exists(caminho))
            {
                throw new IOException();
            }
            else
            {
                using (StreamWriter arquivo = new StreamWriter(caminho))
                {
                    arquivo.WriteLine(texto);

                    arquivo.Close();
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine($"Já existe um arquivo com nome: {nomeArquivo}" +
                               "\n O conteúdo do arquivo será sobrescrito");
            GravarArquivo(nomeArquivo, texto);
        }
    }
    
}