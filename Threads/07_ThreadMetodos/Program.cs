namespace _07_ThreadMetodos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Início: {0}", DateTime.Now);
        Thread.Sleep(3000 /*Milisegundos*/ ); //Determina quanto tempo a thread pode esperar para continuar
        Console.WriteLine("Fim: {0}", DateTime.Now);
    }
}
