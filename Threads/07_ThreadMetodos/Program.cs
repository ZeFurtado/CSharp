namespace _07_ThreadMetodos;

class Program
{
    static void Main(string[] args)
    {
        //Thread.Sleep
        Console.WriteLine("Início: {0}", DateTime.Now);
        Thread.Sleep(3000 /*Milisegundos*/ ); //Determina quanto tempo a thread pode esperar para continuar
        Console.WriteLine("Fim: {0}", DateTime.Now);

        //Thread Join
        Thread t1 = new Thread(RepeticaoThread);
        t1.Start();
        t1.Join();//Espear o fim da execução da primeira thread para prosseguir

        Console.WriteLine("Término do programa!");
        Console.WriteLine("Término do programa!");
        Console.WriteLine("Término do programa!");
        Console.WriteLine("Término do programa!");

        Console.ReadKey();
    }

    static void RepeticaoThread(object ID)
    { 
        for(int i = 0; i < 1000; i++)
        {
            Thread.Sleep(5);
            Console.WriteLine("Thread ID: {0}  - Num: {1}    - ID interno: {2}", ID, i, Thread.CurrentThread.ManagedThreadId);
        }
    } 
    
}
