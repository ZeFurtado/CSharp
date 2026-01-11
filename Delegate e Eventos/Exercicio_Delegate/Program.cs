using System.Security.Cryptography.X509Certificates;

namespace Exercicio_Delegate;

public class Program
{
    static void Main(string[] args)
    {
        int [] inteiros = new int[]{1,4,85,96,146,12,35,48,75,46,5, 50};

        Console.WriteLine("Maior que dez: ");
        foreach(int i in Inteiros.MaiorQueDez(inteiros))
        {
           Console.WriteLine(i);
        }


        Console.WriteLine("Menor que dez: ");
        foreach (int i in Inteiros.MenorQueDez(inteiros))
        {
            Console.WriteLine(i);
        }
    }

    
}
