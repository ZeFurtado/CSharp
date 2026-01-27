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

        Console.WriteLine(endereco);

        Button.botaoHandler += DisparaMensagem;
        Button.Disparar(endereco);    
    }



    static void DisparaMensagem(string endereco)
    {
        WebClient web = new WebClient();
        string html = web.DownloadString(endereco);

        Console.WriteLine(html);
    }
}
