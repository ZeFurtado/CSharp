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

        Ordenar.inteirosHandler = Inteiros.MaiorQueDez;
        Ordenar.inteirosHandler += Inteiros.NumerosImpares;

        int[] arrayOrdenado = Ordenar.Ordena(inteiros);

        foreach(int i in arrayOrdenado)
        {
            Console.WriteLine(i);
        }
        
    }

    

    
}
