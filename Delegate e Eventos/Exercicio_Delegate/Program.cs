using System.Reflection;

namespace Exercicio_Delegate;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random(); 
        int[] inteiros = new int[random.Next(100, 1000)];
        
        for(int x = 0; x < inteiros.Count(); x++)
        {
            inteiros[x] = random.Next(0, 8000); 
        }
        
        Console.WriteLine("---Array orginal: ");
        foreach(int i in inteiros)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------------");

        
        Console.WriteLine("---Array ordenado");

       
        
        Ordenar.inteirosHandler = Inteiros.MaiorQueDez;
        Ordenar.inteirosHandler += Inteiros.NumerosImpares;
        Ordenar.inteirosHandler += Inteiros.MenorQueCem;
        Ordenar.inteirosHandler += Inteiros.NumerosPrimos;

        int[] arrayOrdenado = Ordenar.Ordena(ref inteiros);
        //Ordenar.inteirosHandler += Inteiros.MenorQueCem;
        //Ordenar.inteirosHandler += Inteiros.NumerosPrimos;

        foreach(int i in arrayOrdenado)
        {
            Console.WriteLine(i);
        }
        
    }    
}
