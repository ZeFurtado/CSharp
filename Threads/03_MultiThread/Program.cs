namespace _03_MultiThread;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 5; i++)
        {
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
        }

        Console.WriteLine("Programa finalizado.");
        Console.ReadKey();
    }

    static void ThreadRepeticao()
    {
        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine("Num:  " + i);
        }
    }
}
