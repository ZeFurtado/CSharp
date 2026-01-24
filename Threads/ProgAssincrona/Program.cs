using System.Diagnostics;

namespace ProgAssincrona;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        RealizarOperacao(1, "Joseph", "Griffin");
        RealizarOperacao(2, "Jack", "Morgan");
        RealizarOperacao(3, "Johnson", "Junior");
        stopwatch.Stop();

        Console.WriteLine($"Operação gastou: {stopwatch.ElapsedMilliseconds} milisegundos");
        Console.ReadKey();
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

    static void ExecutarSequencial()
    {
        RealizarOperacao(1, "Joseph", "Griffin");
        RealizarOperacao(2, "Jack", "Morgan");
        RealizarOperacao(3, "Johnson", "Junior");
    }

    static void ExecutarComThreads()
    {
        var t1 = new Thread(() =>
        {
            RealizarOperacao(1, "Eduardo", "Moreira");
        });

        var t2 = new Thread(() =>
        {
            RealizarOperacao(2, "Getúlio", "Nargas");
        });

        var t3 = new Thread(() =>
        {
            RealizarOperacao(3, "Fidalgo", "Castro");
        });
    }
}
