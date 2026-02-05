using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace _03_TaskMult;

public class Program()
{
    static async Task Main(string[] args)
    {
        List<Task> lista = new List<Task>(); 
        lista.Add(Task.Factory.StartNew(Metodo01)); 
        lista.Add(Task.Factory.StartNew(Metodo01)); 
        lista.Add(Task.Factory.StartNew(Metodo01)); 
        lista.Add(Task.Factory.StartNew(Metodo01)); 

        List<string> sites = new List<string>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string[] enderecos = new string[]{"http://www.google.com.br","http://www.microsoft.com","http://www.g1.com.br"};

        WebClient webClient = new WebClient();

        var listaEnderecos = from end in enderecos select DownloadPagina(end, out sites);

        Task.WaitAll(listaEnderecos.ToArray());

        stopwatch.Stop();
        Console.WriteLine("A operação levou: {0} milisegundos", stopwatch.ElapsedMilliseconds);
        Console.ReadKey();


    }

    static void Metodo01()
    {
        int numer = new Random().Next(100, 5000);

        for(int i = 0; i < numer; i++)
        {
            Console.WriteLine("Numero: {0}  ID Tarefa: {1}", i * numer, Task.CurrentId);
        }
    }

    static async Task DownloadPagina(string end)
    {
        WebClient webClient = new WebClient();
        sites.Add(await webClient.DownloadStringTaskAsync(end));
        Console.WriteLine("Download Realizado para a página: " + end);
    }
}