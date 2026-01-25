namespace _05_ThreadSafe;

class Program
{
    static int Rede = 0;
    static object variavelDeControle = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Início: ", DateTime.Now);
        
        for(int i = 0; i < 5; i++)
        {
            Thread t1 = new Thread(ThreadRepeticao);
            t1.IsBackground = true;
            t1.Start();
        }
        Console.ReadKey();
    }

    static void ThreadRepeticao()
    {
        for(int x =0; x < 1000; x++)
        {
            lock(variavelDeControle)
            {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num:  " + i);
                Rede++;
            }
        }
            Console.WriteLine("Fim: " + DateTime.Now);
        }
        
    }
}
