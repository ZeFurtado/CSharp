namespace EscreverArquivoComUsing;


public class Program
{
    static void Main(string[] args)
    {

        using (StreamWriter arquivo = new StreamWriter("/home/lukhas/Documentos/texto.txt"))
        { 
            try
            {
                arquivo.WriteLine("Tralalero Tralala");
                arquivo.WriteLine("Bon giorno\n");

                arquivo.Close();
                Console.WriteLine("Arquivo gravado");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException);
            }
        }
        
    }
}
