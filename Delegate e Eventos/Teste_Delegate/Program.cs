namespace Teste_Delegate;

class Program
{
    delegate void PrintDelegate (string text);
    static void Main(string[] args)
    {
        //Printar na tela
        ConectarBaseDeDados(PrintaNaTela);

        //SalvarArquivo
        ConectarBaseDeDados(PrintaNoArquivo);
    }

    static PrintDelegate PrintaNaTela = (string text) =>
    {
        Console.WriteLine("Printou na tela {0}", DateTime.Now);
    };

    static PrintDelegate PrintaNoArquivo = (string text) =>
    {
        File.AppendAllText("/home/lukhas/Documentos/log.txt", text);
    };

    static void ConectarBaseDeDados(PrintDelegate log)
    {
        //Tentando Conectar
        log($"Testando conexão........{DateTime.Now}");
        Thread.Sleep(1500);
        //Primeira Tentativa
        log($"Conexão falhou!Tentando novamente........{DateTime.Now}");
        Thread.Sleep(3000);
        //Segunda tentativa
        log($"Conexão bem sucedida! {DateTime.Now}"); 
    }
}
