using System.Diagnostics;

namespace ProgAssincrona;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        RealizarOperacao(1, "Joseph", "Griffin");
        RealizarOperacao(2, "Joseph", "Griffin");
        RealizarOperacao(3, "Joseph", "Griffin");
        stopwatch.Stop();

        Console.WriteLine($"Operação gastou: {stopwatch.ElapsedMilliseconds} milisegundos");
    }

    static void RealizarOperacao(int op, string nome, string sobrenome)
    {
        Console.WriteLine($"Iniciando operação {op}....");
        for(int i = 0; i < 100000000; i++)
        {
            var p = new Pessoa(nome, sobrenome, 15);
        }

        Console.WriteLine($"Finalizando operação {op}...");
    }
}
