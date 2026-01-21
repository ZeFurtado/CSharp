using System.Globalization;

namespace _02_Thread;

class Program
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(ThreadRepeticao);
        thread.Start();

        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine("Main: "+ i);
        }
        Console.ReadKey();
    }

    public static void ThreadRepeticao()
    {
        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine("num: "+i);
        }
    }
}
