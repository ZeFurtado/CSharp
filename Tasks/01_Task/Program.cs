using System.Diagnostics;
using System.Net;

namespace _01_Task;

class Program
{
    static void Main(string[] args)
    {

        string endereco = "https://";
        Console.WriteLine("Baixador de HTML: ");
        Console.WriteLine("Digite a url completa do site que deseja baixar {0}", endereco );
        endereco += Console.ReadLine();

        Button button = new Button(endereco);
        Console.WriteLine(endereco);

        Button.botaoHandler += DisparaMensagem;
        //Button.Disparar(endereco);

        Thread t1 = new Thread(button.Disparar); 

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        t1.Start(); 
        
        Thread.Sleep(2000);
        stopwatch.Stop();

        Console.WriteLine("Operação durou: {0} milisegundos", stopwatch.ElapsedMilliseconds);
        
    }



    static async void DisparaMensagem(string endereco)
    {
        WebClient web = new WebClient();
        //string html = web.DownloadString(endereco);
        
        string html = await web.DownloadStringTaskAsync(new Uri(endereco));

        Console.WriteLine(html);
    }
}
