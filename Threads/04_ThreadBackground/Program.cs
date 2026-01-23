namespace _04_ThreadBackground;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Início: ", DateTime.Now);

        for(int i = 0; i < 5; i++)
        {
            Thread t1 = new Thread(ThreadRepeticao);
            t1.IsBackground = true;
            t1.Start();
        }

    }

    static void ThreadRepeticao()
    {
        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine("Num:  " + i);
        }

        Console.WriteLine("Fim: " + DateTime.Now);
    }
}
