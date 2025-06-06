namespace Execoes;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o número 1: ");
        string digitado = Console.ReadLine();

        if (digitado == "1")
        {
            Console.WriteLine("Correto");
        }
        else
        {
            throw new Exception("O valor digitado está incorreto");   
        }
    }
}