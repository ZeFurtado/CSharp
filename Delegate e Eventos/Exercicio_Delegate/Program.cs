using System.Reflection;

namespace Exercicio_Delegate;

public class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[]{10,14,5,2,3,9,7,17,65,100,45,103,199};
        Random random = new Random(); 
        int[] inteiros = new int[random.Next(100, 1000)];
        
        for(int x = 0; x < array1.Count(); x++)
        {
            inteiros[x] = random.Next(0, 8000); 
        }
        
        Console.WriteLine("---Array orginal: ");
        foreach(int i in array1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------------");

        
        Console.WriteLine("---Array ordenado");

       
        
        Ordenar.inteirosHandler = Inteiros.MaiorQueDez;
        Ordenar.inteirosHandler += Inteiros.NumerosImpares;
        Ordenar.inteirosHandler += Inteiros.MenorQueCem;

        int[] arrayOrdenado = Ordenar.Ordena(ref array1);
        //Ordenar.inteirosHandler += Inteiros.MenorQueCem;
        //Ordenar.inteirosHandler += Inteiros.NumerosPrimos;

        foreach(int i in arrayOrdenado)
        {
            Console.WriteLine(i);
        }
        
    }    
}
