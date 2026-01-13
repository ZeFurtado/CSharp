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

    /*public int[] NumerosPrimos(int[] array)
    {
        int[] arrayTemp = new int[array.Count()];
        int p = -1;
    }*/

}