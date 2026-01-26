using System.Diagnostics;

namespace _06_ThreadID;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Início: {0}", DateTime.Now);
        stopwatch.Start();

        for(int i =0; i < 5; i++)
        {
            var tM = new Thread(RepeticaoThread);
            tM.IsBackground = true;
            tM.Start(i);
        }

        stopwatch.Stop();
        Console.WriteLine("A aplicação durou: {0} milisegundos!", stopwatch.ElapsedMilliseconds);
        
        Console.ReadKey();
    }



    static void RepeticaoThread(object ID)
    {
        
        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine("Thread ID: {0}  - Num: {1}    - ID interno: {2}", ID, i, Thread.CurrentThread.ManagedThreadId);
        }
        
    } 
}
