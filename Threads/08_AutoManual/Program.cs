namespace _08_AutoManual;

class Program
{

    static AutoResetEvent auto01;
    static ManualResetEvent manual01;
    static void Main(string[] args)
    {

        manual01 = new ManualResetEvent(false);
        auto01 = new AutoResetEvent(false);

        Thread t1 = new Thread(Executa01);
        t1.Start();
        
        Thread t2 = new Thread(Executa02);
        t2.Start();

        Thread.Sleep(5000);
        manual01.Set();
        manual01.Reset();

        auto01.Set();

        Thread.Sleep(3000);
        auto01.Set();
        manual01.Set();


        Console.ReadKey();
    }

    static void Executa01()
    {
        Console.WriteLine("01 - Iniciando Executa01.");
        manual01.WaitOne();
        Console.WriteLine("02 - Em execução 01 Executa01.");
        Console.WriteLine("03 - Em execução 02 Executa01.");
        manual01.WaitOne();
        Console.WriteLine("04 - Iniciando Executa01.");
    }

    static void Executa02()
    {
        Console.WriteLine("01 - Iniciando Executa02.");
        auto01.WaitOne();
        Console.WriteLine("02 - Em execução 01 Executa02.");
        Console.WriteLine("03 - Em execução 02 Executa02.");
        auto01.WaitOne();
        Console.WriteLine("04 - Iniciando Executa02.");
    }
}
