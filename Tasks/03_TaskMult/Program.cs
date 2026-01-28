using System.Diagnostics;
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

        Stopwatch stopwatch = new Stopwatch();
        
        stopwatch.Start();
        try
        {
            foreach(Task t in lista)
            {
                t.Start();
            }
        }catch(InvalidOperationException ex)
        {
            Console.WriteLine("Exceção operação inválida");
        }

        Task.WaitAll(lista.ToArray());
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
}