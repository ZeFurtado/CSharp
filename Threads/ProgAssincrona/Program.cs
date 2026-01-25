using System.Diagnostics;

namespace ProgAssincrona;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("-----Operação Sequencial-----");
        Console.WriteLine("Hora início: {0}", DateTime.Now);
        
        stopwatch.Start();
        ExecutarSequencial();
        stopwatch.Stop();
        
        Console.WriteLine("Hora fim: {0}", DateTime.Now);
        Console.WriteLine("Operação gastou: {0} milisegundos", stopwatch.ElapsedMilliseconds);
        

        Console.WriteLine("------Operação em Threads-----");
        Console.WriteLine("Hora início: {0}", DateTime.Now);
        
        stopwatch.Restart();
        ExecutarComThreads();
        stopwatch.Stop();
        
        Console.WriteLine("Hora fim: {0}", DateTime.Now);

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
            RealizarOperacao(4, "Eduardo", "Moreira");
        });

        var t2 = new Thread(() =>
        {
            RealizarOperacao(5, "Getúlio", "Nargas");
        });

        var t3 = new Thread(() =>
        {
            RealizarOperacao(6, "Fidalgo", "Castro");
        });

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }

    static void ExecutarComTasks()
    {
        var t1 = Task.Run<int>(() =>
        {
            RealizarOperacao(7, "Nancy", "Spugen");
            return 7;
        });

        var t2 = Task.Run<int>(() =>
        {
            RealizarOperacao(8, "Ozzy", "Osbourne");
            return 8;
        });

        var t3 = Task.Run<int>(() =>
        {
            RealizarOperacao(9, "Millie", "Brown");
            return 9;  
        });


    }
}
