namespace Exercicio_Delegate;


public class Inteiros
{
    public static int[] MaiorQueDez(ref int[] array)
    {
        Console.WriteLine("Obtendo números maiores que dez...");
        Thread.Sleep(3000);

        int[] arrayTemp = new int[array.Count()];
        int p = -1;
        foreach (int i in array)
        {
            if(i > 10)
            {
                p++;
                arrayTemp[p] = i;
            }
        }

        int[] arrayRetorno = new int[p + 1];

        for(int q = 0; q < p + 1; q++)
        {
           arrayRetorno[q] = arrayTemp[q];
        }

        array = arrayRetorno;
        return array;
    }

    public static int[] MenorQueDez(ref int[] array)
    {

        Console.WriteLine("Obtendo números menores que dez...");
        Thread.Sleep(3000);

        int[] arrayTemp = new int[array.Count()];
        int p = -1;
        foreach (int i in array)
        {
            if(i < 10)
            {
                p++;
                arrayTemp[p] = i;
            }
        }

        int[] arrayRetorno = new int[p + 1];

        for(int q = 0; q < p + 1; q++)
        {
           arrayRetorno[q] = arrayTemp[q];
        }

        array = arrayRetorno;
        return array;
    }

    public static int[] MenorQueCem(ref int[] array)
    {

        Console.WriteLine("Obtendo números menores que cem...");
        Thread.Sleep(3000);

        int[] arrayTemp = new int[array.Count()];
        int p = -1;
        foreach (int i in array)
        {
            if(i < 100)
            {
                p++;
                arrayTemp[p] = i;
            }
        }

        int[] arrayRetorno = new int[p + 1];

        for(int q = 0; q < p + 1; q++)
        {
           arrayRetorno[q] = arrayTemp[q];
        }

        array = arrayRetorno;
        return array;
    }

    public static int[] NumerosPares(ref int[] array)
    {

        Console.WriteLine("Obtendo números pares...");
        Thread.Sleep(3000);

        int[] arrayTemp = new int[array.Count()];
        int p = -1;

        foreach (int i in array)
        {
            if(i % 2 == 0)
            {
                p++;
                arrayTemp[p] = i;
            }
        }

        int[] arrayRetorno = new int[p + 1];

        for(int q = 0; q < p + 1; q++)
        {
           arrayRetorno[q] = arrayTemp[q];
        }

        array = arrayRetorno;
        return array;
    }

    public static int[]NumerosImpares(ref int[] array)
    {
        
        Console.WriteLine("Obtendo números ímpares...");
        Thread.Sleep(3000);

        int[] arrayTemp = new int[array.Count()];
        int p = -1;

        foreach (int i in array)
        {
            if(i % 2 != 0)
            {
                p++;
                arrayTemp[p] = i;
            }
        }

        int[] arrayRetorno = new int[p + 1];

        for(int q = 0; q < p + 1; q++)
        {
           arrayRetorno[q] = arrayTemp[q];
        }

        array = arrayRetorno;
        return array;
    }

    public static int[] NumerosPrimos(ref int[] array)
    {

        Console.WriteLine("Obtendo números primos..."); 
        Thread.Sleep(3000);
        
        int[] arrayTemp = new int[array.Count()];
        int p = -1;

        foreach (int i in array)
        {
            if(EhPrimo(i))
            {
              p++; 
              arrayTemp[p] = i;  
            }   
        }

        int[] arrayRetorno = new int[p + 1];

        for(int q = 0; q < p + 1; q++)
        {
           arrayRetorno[q] = arrayTemp[q];
        }

        array = arrayRetorno;
        return array;
    }

    private static bool EhPrimo(int i)
    {
        if(i < 2) return false;
        if(i == 2 || i == 3) return true;
        
        for(int n = 2; n <= (int)Math.Sqrt(i); n++)
        {
            if(i % n == 0) return false;
        }

        return true;
    }

}