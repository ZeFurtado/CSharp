namespace Exercicio_Delegate;


public class Inteiros
{
    public static int[] MaiorQueDez(int[] array)
    {
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

        return arrayRetorno;
    }

    public static int[] MenorQueDez(int[] array)
    {
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

        return arrayRetorno;
    }

    public static int[] NumerosPares(int[] array)
    {
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

        return arrayRetorno;
    }

    public static int[] NumerosImpares(int[] array)
    {
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

        return arrayRetorno;
    }

    public static int[] NumerosPrimos(int[] array)
    {
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

        return arrayRetorno;
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